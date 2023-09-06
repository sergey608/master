# define the correct answers
correct_answers = ['A', 'C', 'A', 'A', 'D', 'B', 'C', 'A', 'C', 'B', 'A', 'D', 'C', 'A', 'D', 'C', 'B', 'B', 'D', 'A']

# read student's answers from file
with open('student_solution.txt') as f:
    student_answers = [line.strip() for line in f]

# compare answers and count correct and incorrect answers
correct_count = 0
incorrect_count = 0
incorrect_questions = []
for i, (correct, student) in enumerate(zip(correct_answers, student_answers)):
    if correct == student:
        correct_count += 1
    else:
        incorrect_count += 1
        incorrect_questions.append(i+1)

# check if student passed the test
passed = correct_count >= 15

# output result
if passed:
    print("The student passed the test.")
else:
    print("The student failed the test.")

print(f"Total correct answers: {correct_count}")
print(f"Total incorrect answers: {incorrect_count}")
print(f"Incorrect questions: {incorrect_questions}")
