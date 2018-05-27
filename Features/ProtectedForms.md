# Feature: ProtectedForms
## Requries: N/A

**Description**

ProtectedForms is an anti-form patcher solution. It will stop tools like `Cheat Engine` and alike tools from being able to switch to a form the user should not be in if they are not authenticated and have a valid serial.

**How can I use this feature?**

*Assuming you have created an application already with EZLib referenced.*

You will reference it onto your forms that you would like to be "protected". You will change the inheritance of `Form` to `ProtectedForms`.
![ProtectedForms](https://i.imgur.com/wpSZ6N8.png)