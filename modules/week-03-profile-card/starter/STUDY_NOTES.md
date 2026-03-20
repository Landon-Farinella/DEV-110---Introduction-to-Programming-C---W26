# Week 3: Personal Profile Card - Study Notes

**Name:**

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer: String, Integer, Double, Bool
A string stores text - such as your name, a boolean stores a true or false - such as whether or not you are an honor student, a double stores a number with decimals - such as your height, an integer stores a whole number - such as your age

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: because GPA uses decimal precision. It allows for more precise grades rather than just having 1 - 4

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: with this little guy:         bool isFullTime = fullTimeAnswer.ToLower() == "yes";
(this is basically saying "if input equals yes then true, if not then false")

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: For oganization sake. It's easier to read and more understandable when its organized.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: birth year, years to graduation, height conversion, honor status, age in months

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: To reduce redundant input and pointless extra work

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: this wasnt very hard at all. the calculations were much simpler than I though they were going to be.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: no challenge tho

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: type casting

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: with these: int.Parse(), double.Parse() I would assume

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: I mean, the answer is right there. feet = inches / 12, remaining = inches % 12

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: if their gpa is greater than or equals to 3.5, then true

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: F2 formats to the second decimal place

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: well if the boolean is true then it writes the true text
if its false it writes the false text

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I used neat little boxes, some spacing, and some lines

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: Weight, Time till next Birthday, Relationship status, :(

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer:precision

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: i was going to say social media profiles but you already listed that,

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. math is very easy in c#
2. its importnant to use precision
3. how to convert string to boolean
4.
5.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: none, I have known these for the past 10 months thanks to unreal engine

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: more accurate information, high precision, etc

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: i tested what the program asked for - text, numbers, decimals, etc.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: nay

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: by testing them

## Time Spent

**Total time:** [like 30 minutes]

**Breakdown:**

-   Understanding data types and planning variables: [1 minute]
-   Collecting user input with correct types: [13 minute]
-   Implementing calculations: [8 minute]
-   Formatting output: [6 minute]
-   Testing and debugging: [12 minute]
-   Writing documentation: [10 minutes]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: writing everything out

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer:nothing

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: makes things more understandable, precision and accuracy, etc.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: game character, or anything game related.
