[![GitHub stars](https://img.shields.io/github/stars/MrBreakNFix/process-elevation-helper?style=social)](https://github.com/MrBreakNFix/process-elevation-helper/stargazers)
[![GitHub forks](https://img.shields.io/github/forks/MrBreakNFix/process-elevation-helper?style=social)](https://github.com/MrBreakNFix/process-elevation-helper/network)
[![GitHub issues](https://img.shields.io/github/issues/MrBreakNFix/process-elevation-helper)](https://github.com/MrBreakNFix/process-elevation-helper/issues)

# Process Elevation Helper

**Process Elevation Helper** is a companion utility that enables secure and controlled execution of commands with elevated privileges. It works in conjunction with the [Process Elevation](https://github.com/MrBreakNFix/process-elevation) repository, allowing you to launch programs from a different user account, bypassing UAC prompts.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [License](#license)

## Introduction

In various scenarios, you might need to execute specific commands or operations with elevated privileges without exposing sensitive information, such as passwords. Process Elevation Helper provides a secure and seamless way to achieve this by establishing communication with the Process Elevation utility using named pipes.

## Features

- **UAC Prompt Bypass:** Process Elevation Helper allows you to bypass UAC prompts, providing a smoother experience when running commands with elevated privileges.

- **Auto Start:** It communicates with the [Process Elevation](https://github.com/MrBreakNFix/process-elevation), which starts when the computer does.

## Prerequisites

Before using Process Elevation Helper, make sure you have the following prerequisites in place:

- .NET Core

- [Process Elevation](https://github.com/MrBreakNFix/process-elevation)

## Installation

1. Download the release of `elev.exe`

2. Create a folder called `elev` and put `elev.exe` in it

3. Add a system environment variable under `PATH`, so that you can access it under the run menu. Run under a system/admin command prompt to do this, or do it in environmental veriable settings.
`setx PATH "%PATH%;C:\Users\your-name\elevsw\elevhelper" /m` (TODO: do this automatically.)

## Usage

elev.exe ProgramPath, for example: `elev cmd` creates the CMD window under the other user.

![Using the tool](https://i.imgur.com/gDCqNVT.png) 

This tool is different because it works with programs that runas does not support
