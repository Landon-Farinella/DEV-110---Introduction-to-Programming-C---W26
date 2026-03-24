# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:Landon Farinella** replace-with-your-name

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer choosetemplate – selects story; collectwords – gathers words; readyesno – yes/no input; readintinrange – validates numbers; readnonemptystring – validates strings

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: improves readability, reduces bugs

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: stores title, prompts, and story text for each template

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: allows same logic to work with multiple stories

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer: inside collectwords and generatestory

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer:  helped understand flow and spot errors

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer:notimplementedexception in generatestory; fixed with string formatting

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1. helper methods improve structure
2. input validation is important
3. classes store reusable data

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer: breaking into methods clarified program flow

## Time Spent

**Total time:** [2 hours]

**Breakdown:**

- Planning structure (methods/classes): [0.5 hours]
- Input validation: [0.2 hours]
- Story templates + formatting: [0.2 hours]
- Testing and debugging: [1.2 hours]
- Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: debugging because i ran into bugs

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: would add more templates and better formatting

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: breaking program into smaller parts made debugging easier
