# Examination System

This repository contains the code for an Examination System designed to manage and conduct different types of exams, such as Final and Practical exams. The system supports various question formats and leverages object-oriented programming principles.

## Features

1. **Question Class**: Represents a question with the following attributes:
    - Header of the question
    - Body of the question
    - Mark

2. **Exam Types**:
    - Final Exam
    - Practical Exam

3. **Question Types**:
    - Final Exam: True or False, Multiple Choice Questions (MCQ)
    - Practical Exam: Multiple Choice Questions (MCQ)

4. **Answer Class**: Represents an answer with the following attributes:
    - AnswerId
    - AnswerText
    - IsCorrect (indicates if the answer is correct)

5. **Exam Class**: Base class that describes common attributes and functionality for all exams:
    - Time of the exam
    - Number of questions
    - Show Exam functionality (implementation varies by exam type)

6. **Subject Class**: Represents a subject with the following attributes:
    - Subject Id
    - Subject Name
    - Exam of the subject

7. **Functional Requirements**:
    - Practical Exam shows the correct answer after finishing the exam.
    - Final Exam shows the questions, answers, and grade.

8. **Main Functionality**:
    - Declare a subject object to create one type of exam.

## Design Principles

- **Inheritance and Polymorphism**: Base Question class with derived classes for each question type. Base Exam class with derived classes for Final and Practical exams.
- **Interfaces**: Implement ICloneable and IComparable.
- **Constructor Chaining**: Used where necessary.
- **Overriding ToString**: For better string representation of objects.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Running the Application

1. Clone the repository:
    ```sh
    git clone https://github.com/Yahya-Elebrashy/Examination-System.git
    ```
2. Navigate to the project directory:
    ```sh
    cd Examination-System
    ```
3. Build the project:
    ```sh
    dotnet build
    ```
4. Run the project:
    ```sh
    dotnet run
    ```

## Usage

The main entry point of the application is in the `Program.cs` file. Here, you will find the creation of a `Subject` object and the instantiation of an exam.


