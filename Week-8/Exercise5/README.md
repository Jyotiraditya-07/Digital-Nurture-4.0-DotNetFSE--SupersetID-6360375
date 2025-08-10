# Clean Up and Push to Remote Git

## Objectives

This hands-on lab helps you understand how to:
- Clean up a Git repository
- Push local changes to a remote GitHub repository

---

## Prerequisites

- Hands-on Lab ID: `Git-T03-HOL_002`
- Git must be installed on your machine
- Access to a GitHub repository
- Do **not** use Cognizant credentials to log in to GitHub — create a personal GitHub account

---

## Lab Instructions (Git Bash Commands)

### Step 1: Verify if the working tree is clean

```bash
git status
```
Expected output:
> On branch main
> Your branch is up to date with 'origin/main'.
> nothing to commit, working tree clean

### Step 2: List all local and remote branches

```bash
git branch -a
```
Example output:
```bash
* master
  remotes/origin/HEAD -> origin/main
  remotes/origin/main
```

### Step 3: Pull the latest changes from the remote master branch

```bash
git pull origin master
```

### Step 4: Push your local changes from Git-T03-HOL_002 to remote

If changes are already committed:
```bash
git push origin main
```

If not yet committed:

```bash
git add .
git commit -m "Completed Git-T03-HOL_002 hands-on lab"
git push origin main
```

### Step 5: Verify changes on GitHub
- Go to your GitHub repository in the browser.
- Switch to the `main` branch.
- Confirm your recent commit or file changes are visible.