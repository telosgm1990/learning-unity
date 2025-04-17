# Learning Unity

Project to learn Unity basics.

## 1. Cloning project

To clone this repo, type in terminal:

```bash
git clone git@github.com:telosgm1990/learning-unity.git
```

## 2. Dependencies

### 2.1. .NET (Ref 1.)

Add the apt repository:

```bash
sudo add-apt-repository ppa:dotnet/backports
```

Install the SDK:

```bash
sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-9.0
```

### 2.2. Unity Hub (Ref 2.)

Add the public signing key:

```bash
wget -qO - https://hub.unity3d.com/linux/keys/public | gpg --dearmor | sudo tee /usr/share/keyrings/Unity_Technologies_ApS.gpg > /dev/null
```

Add the Unity Hub repository:

```bash
sudo sh -c 'echo "deb [signed-by=/usr/share/keyrings/Unity_Technologies_ApS.gpg] https://hub.unity3d.com/linux/repos/deb stable main" > /etc/apt/sources.list.d/unityhub.list'
```

Update the package cache and install the package:

```bash
sudo apt update && \
  sudo apt-get install unityhub
```

### 2.3. Android Build Support for Unity Hub

With project open, go to `File` > `Build Profiles` > `Android`, and click in `Install with Unity Hub` button.

An installation wizard will open, just follow it (use recommended options).

## 3. References

1. https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu-install?tabs=dotnet9&pivots=os-linux-ubuntu-2204
2. https://docs.unity3d.com/hub/manual/InstallHub.html
