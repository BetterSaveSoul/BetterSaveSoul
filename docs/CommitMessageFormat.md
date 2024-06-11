# Commit Message Guide

## Title
- **Type & Subject**: Start with a type followed by a subject.
  - Types can be:
    - `feat`: A new feature
    - `fix`: A bug fix
    - `docs`: Documentation changes
    - `style`: Changes that do not affect the meaning of the code (white-space, formatting, missing semi-colons, etc)
    - `refactor`: A code change that neither fixes a bug nor adds a feature
    - `perf`: A code change that improves performance
    - `test`: Adding missing tests or correcting existing tests
    - `chore`: Changes to the build process or auxiliary tools and libraries such as documentation generation
- **Issue Tracker**: Include the issue tracker ID within the title.
- **Format**: Keep under 50 characters, capitalize the first letter, and avoid ending with a period.

## Body
- **Explanation**: Use the body to explain the 'what' and 'why', not the 'how'.
- **Length**: Limit line length to 72 characters.
- **Separation**: Ensure a blank line between the title and body.

Remember to use an imperative tone and keep the commit message concise.

## Example
```
feat: Summarize changes in around 50 characters or less #123

More detailed explanatory text, if necessary. Wrap it to about 72
characters or so. In some contexts, the first line is treated as the
subject of the commit and the rest of the text as the body. The
blank line separating the title from the body is critical (unless
you omit the body entirely)
```