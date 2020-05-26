# RaspberryFlasher_CSharp
Example of a C# Raspberry Pi GPIO configuration.

The progame Visual Studio Codes `tasks` and `launch` configurations.

## .vscode/task.json
There are 3 tasks
* build
* publish
* deploy

The deploy task is the more interesting.  It takes the `publish` task output and deploys it on the r Pi. Rsync is used to deploy only those files which change. This is more efficient than using SCP to copy the entire contents of the Publish task output.

Note: SSH keys are used for authentication. This requires that the host public key has been added to the Pi's `~/.ssh/authorized_keys` file.

# .vscode/launch.json
Configures remote debug mode and triggers the `deploy` task (and its `publish` and `build` dependencies). 