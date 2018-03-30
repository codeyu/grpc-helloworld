# grpc-helloworld


windows:

```
tools/windows_x64/protoc.exe -Isrc/HelloWorldService --csharp_out  src/HelloWorldService s
rc/HelloWorldService/helloworld.proto --grpc_out src/HelloWorldService --plugin=protoc-gen-grpc=tools/windows_x64/grpc_c
sharp_plugin.exe
```