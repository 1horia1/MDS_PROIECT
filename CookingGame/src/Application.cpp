#include <GL/glew.h>
#include <GLFW/glfw3.h>

#include <iostream>

// Button structure
struct Button {
    float x1, y1, x2, y2;
    const char* label;
};

// Convert screen coordinates to OpenGL coordinates
void screenToGLCoords(double x, double y, int width, int height, float& glX, float& glY) {
    glX = (float)((x / width) * 2.0 - 1.0);
    glY = (float)(1.0 - (y / height) * 2.0);
}

// Check if a point is inside a button
bool isInsideButton(float x, float y, Button btn) {
    return x >= btn.x1 && x <= btn.x2 && y >= btn.y1 && y <= btn.y2;
}

// Draw a rectangle (button)
void drawButton(Button btn) {
    glBegin(GL_QUADS);
    glVertex2f(btn.x1, btn.y1);
    glVertex2f(btn.x2, btn.y1);
    glVertex2f(btn.x2, btn.y2);
    glVertex2f(btn.x1, btn.y2);
    glEnd();
}

bool menuActive = true;

int main() {
    GLFWwindow* window;

    if (!glfwInit())
        return -1;

    window = glfwCreateWindow(640, 480, "Menu Example", NULL, NULL);
    if (!window) {
        glfwTerminate();
        return -1;
    }

    glfwMakeContextCurrent(window);
    if (glewInit() != GLEW_OK)
        std::cout << "GLEW Init Failed!" << std::endl;

    std::cout << glGetString(GL_VERSION) << std::endl;

    int width, height;
    glfwGetFramebufferSize(window, &width, &height);

    // Define buttons
    Button startBtn = { -0.3f, 0.1f, 0.3f, 0.4f, "Start" };
    Button quitBtn = { -0.3f, -0.4f, 0.3f, -0.1f, "Quit" };

    // Main loop
    while (!glfwWindowShouldClose(window)) {
        glClear(GL_COLOR_BUFFER_BIT);

        if (menuActive) {
            // Draw buttons
            glColor3f(0.2f, 0.8f, 0.2f); // Green for Start
            drawButton(startBtn);
            glColor3f(0.8f, 0.2f, 0.2f); // Red for Quit
            drawButton(quitBtn);
        }
        else {
            // Game or main content rendering goes here
            glColor3f(0.5f, 0.5f, 1.0f);
            glBegin(GL_TRIANGLES);
            glVertex2f(-0.5f, -0.5f);
            glVertex2f(0.5f, -0.5f);
            glVertex2f(0.0f, 0.5f);
            glEnd();
        }

        glfwSwapBuffers(window);
        glfwPollEvents();

        if (glfwGetMouseButton(window, GLFW_MOUSE_BUTTON_LEFT) == GLFW_PRESS) {
            double mx, my;
            glfwGetCursorPos(window, &mx, &my);
            glfwGetFramebufferSize(window, &width, &height);

            float glX, glY;
            screenToGLCoords(mx, my, width, height, glX, glY);

            if (menuActive) {
                if (isInsideButton(glX, glY, startBtn)) {
                    std::cout << "Start button clicked!" << std::endl;
                    menuActive = false;
                }
                else if (isInsideButton(glX, glY, quitBtn)) {
                    std::cout << "Quit button clicked!" << std::endl;
                    glfwSetWindowShouldClose(window, true);
                }
            }
        }
    }

    glfwTerminate();
    return 0;
}
