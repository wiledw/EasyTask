# EasyTask Frontend

This is the frontend for the EasyTask application, built with React and TypeScript using Create React App.

## Setup Steps

1. **Install dependencies:**
   ```sh
   npm install
   ```
2. **Start the development server:**
   ```sh
   npm start
   ```
   The app will run at [http://localhost:3000](http://localhost:3000).

3. **Build for production:**
   ```sh
   npm run build
   ```
   The production-ready files will be in the `build/` folder.

## Explanation Notes

- This frontend communicates with the EasyTask backend API to manage tasks.
- It uses React functional components and hooks for state management.
- All API calls are organized in the `src/api` folder.
- Components are modular and located in `src/components`.

## File Structure

```
task-ui/
├── public/                # Static assets and the HTML template
├── src/
│   ├── api/
│   │   └── task.ts        # API functions for task operations (GET, POST, PUT, DELETE)
│   ├── components/
│   │   ├── TaskList.tsx   # Displays the list of tasks
│   │   ├── TaskItem.tsx   # Represents a single task item with actions
│   │   └── TaskForm.tsx   # Form to add a new task
│   ├── App.tsx            # Main app component, sets up layout and routing
│   ├── index.tsx          # Entry point, renders the app
│   ├── App.css            # Styles for the App component
│   ├── index.css          # Global styles
│   ├── logo.svg           # React logo
│   ├── reportWebVitals.ts # Performance measuring (optional)
│   ├── setupTests.ts      # Test setup for Jest
│   ├── App.test.tsx       # Example test for App component
│   └── react-app-env.d.ts # TypeScript environment definitions
├── package.json           # Project metadata and scripts
├── package-lock.json      # Dependency lock file
├── tsconfig.json          # TypeScript configuration
├── .gitignore             # Files and folders to ignore in git
└── README.md              # This file
```

## Component Overview

- **TaskList.tsx**: Fetches and displays all tasks using the API. Renders a list of `TaskItem` components.
- **TaskItem.tsx**: Shows a single task, with options to toggle completion or delete.
- **TaskForm.tsx**: Provides a form to add a new task.
- **task.ts**: Contains functions to interact with the backend API (fetch, create, update, delete tasks).

## Notes
- Make sure the backend API is running and accessible for the frontend to function properly.
- You can customize styles in the CSS files as needed.

---

This project was bootstrapped with [Create React App](https://github.com/facebook/create-react-app). For more details, see the [Create React App documentation](https://facebook.github.io/create-react-app/docs/getting-started).
