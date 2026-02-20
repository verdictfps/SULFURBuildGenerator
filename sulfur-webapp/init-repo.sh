#!/usr/bin/env bash
# Helper script to create a new GitHub repo and push sulfur-webapp folder.
set -e
if [ -z "$1" ]; then
  echo "Usage: $0 <github-username-or-org>"
  exit 1
fi
USER=$1
REPO=sulfur-webapp
cd sulfur-webapp
# initialize local repo if not already
if [ ! -d .git ]; then
  git init
  git add .
  git commit -m "Initial commit: sulfur webapp" || true
fi
# create remote via gh
if command -v gh >/dev/null 2>&1; then
  gh repo create $USER/$REPO --public --source=. --push
else
  echo "Install GitHub CLI (gh) to create remote automatically. Otherwise create a repo on GitHub and run:"
  echo "git remote add origin https://github.com/$USER/$REPO.git"
  echo "git push -u origin master"
fi
