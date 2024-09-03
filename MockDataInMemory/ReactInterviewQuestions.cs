using Quiz_Api.Models;
using System.Collections.Generic;
namespace Quiz_Api.MockDataInMemory
{
    public static class ReactInterviewQuestions
    {


        public static List<Question> GenerateMockReactQuestions()
        {
            return new List<Question>
        {
            new Question { QId = 1, QnInWords = "What are props in React and how do you use them?", Option1 = "Props are used to store component state", Option2 = "Props are used to pass data between components", Option3 = "Props are used to handle events", Option4 = "Props are used to manage lifecycle methods", Answer = 2 },
            new Question { QId = 2, QnInWords = "How do you manage state in a functional component using hooks?", Option1 = "Using the useState hook", Option2 = "Using the useEffect hook", Option3 = "Using the useContext hook", Option4 = "Using the useReducer hook", Answer = 1 },
            new Question { QId = 3, QnInWords = "Explain the difference between controlled and uncontrolled components.", Option1 = "Controlled components manage their own state", Option2 = "Uncontrolled components use refs to access the DOM", Option3 = "Controlled components use refs to access the DOM", Option4 = "Uncontrolled components manage their own state", Answer = 2 },
            new Question { QId = 4, QnInWords = "How do you handle form submissions in React?", Option1 = "Using the onSubmit event handler", Option2 = "Using the onChange event handler", Option3 = "Using the onClick event handler", Option4 = "Using the onInput event handler", Answer = 1 },
            new Question { QId = 5, QnInWords = "What is the Context API and how do you use it?", Option1 = "Context API is used to manage component state", Option2 = "Context API is used to pass data through the component tree without props", Option3 = "Context API is used to handle side effects", Option4 = "Context API is used to manage component lifecycle", Answer = 2 },
            new Question { QId = 6, QnInWords = "How do you optimize performance in a large React application?", Option1 = "Using the useEffect hook", Option2 = "Using the useState hook", Option3 = "Using React.memo and useCallback", Option4 = "Using the useContext hook", Answer = 3 },
            new Question { QId = 7, QnInWords = "What are higher-order components (HOCs) and how do you use them?", Option1 = "HOCs are components that manage state", Option2 = "HOCs are components that handle events", Option3 = "HOCs are functions that take a component and return a new component", Option4 = "HOCs are components that manage lifecycle methods", Answer = 3 },
            new Question { QId = 8, QnInWords = "Explain the use of useEffect hook with an example.", Option1 = "useEffect is used to manage state", Option2 = "useEffect is used to handle side effects", Option3 = "useEffect is used to pass data between components", Option4 = "useEffect is used to manage component lifecycle", Answer = 2 },
            new Question { QId = 9, QnInWords = "How do you handle errors in a React application?", Option1 = "Using the useState hook", Option2 = "Using the useEffect hook", Option3 = "Using error boundaries", Option4 = "Using the useContext hook", Answer = 3 },
            new Question { QId = 10, QnInWords = "What is the purpose of React.memo and how do you use it?", Option1 = "React.memo is used to manage state", Option2 = "React.memo is used to handle side effects", Option3 = "React.memo is used to optimize performance by memoizing components", Option4 = "React.memo is used to manage component lifecycle", Answer = 3 },
            new Question { QId = 11, QnInWords = "How do you implement lazy loading in React?", Option1 = "Using the useState hook", Option2 = "Using the useEffect hook", Option3 = "Using React.lazy and Suspense", Option4 = "Using the useContext hook", Answer = 3 },
            new Question { QId = 12, QnInWords = "What are React portals and when would you use them?", Option1 = "Portals are used to manage state", Option2 = "Portals are used to handle side effects", Option3 = "Portals are used to render children into a DOM node outside of the parent component", Option4 = "Portals are used to manage component lifecycle", Answer = 3 },
            new Question { QId = 13, QnInWords = "How do you manage global state in a React application?", Option1 = "Using the useState hook", Option2 = "Using the useEffect hook", Option3 = "Using the useContext hook or state management libraries like Redux", Option4 = "Using the useReducer hook", Answer = 3 },
            new Question { QId = 14, QnInWords = "Explain the concept of lifting state up in React.", Option1 = "Lifting state up means moving state to a common ancestor component", Option2 = "Lifting state up means moving state to a child component", Option3 = "Lifting state up means moving state to a sibling component", Option4 = "Lifting state up means moving state to a grandchild component", Answer = 1 },
            new Question { QId = 15, QnInWords = "How do you handle side effects in a React application?", Option1 = "Using the useState hook", Option2 = "Using the useEffect hook", Option3 = "Using the useContext hook", Option4 = "Using the useReducer hook", Answer = 2 },
            new Question { QId = 16, QnInWords = "What is the difference between useState and useReducer hooks?", Option1 = "useState is used for complex state logic, useReducer is used for simple state logic", Option2 = "useState is used for simple state logic, useReducer is used for complex state logic", Option3 = "useState is used for managing side effects, useReducer is used for managing state", Option4 = "useState is used for managing state, useReducer is used for managing side effects", Answer = 2 },
            new Question { QId = 17, QnInWords = "How do you test React components?", Option1 = "Using the useState hook", Option2 = "Using the useEffect hook", Option3 = "Using testing libraries like Jest and React Testing Library", Option4 = "Using the useContext hook", Answer = 3 },
            new Question { QId = 18, QnInWords = "What are custom hooks and how do you create one?", Option1 = "Custom hooks are functions that manage state", Option2 = "Custom hooks are functions that handle side effects", Option3 = "Custom hooks are functions that reuse stateful logic", Option4 = "Custom hooks are functions that manage component lifecycle", Answer = 3 },
            new Question { QId = 19, QnInWords = "How do you handle routing in a React application?", Option1 = "Using the useState hook", Option2 = "Using the useEffect hook", Option3 = "Using React Router", Option4 = "Using the useContext hook", Answer = 3 },
            new Question { QId = 20, QnInWords = "Explain the concept of reconciliation in React.", Option1 = "Reconciliation is the process of managing state", Option2 = "Reconciliation is the process of handling side effects", Option3 = "Reconciliation is the process of updating the DOM to match the React elements", Option4 = "Reconciliation is the process of managing component lifecycle", Answer = 3 }
        };
        }
    }
}
