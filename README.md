# grpc-helloworld

issue: `cannot bind to port`
please look hosts file:
```
127.0.0.1         localhost
```



windows:

```
tools/windows_x64/protoc.exe -Isrc/HelloWorldService --csharp_out  src/HelloWorldService s
rc/HelloWorldService/helloworld.proto --grpc_out src/HelloWorldService --plugin=protoc-gen-grpc=tools/windows_x64/grpc_c
sharp_plugin.exe
```

macos:

```
tools/macosx_x64/protoc -Isrc/HelloWorldService --csharp_out  src/HelloWorldService s
rc/HelloWorldService/helloworld.proto --grpc_out src/HelloWorldService --plugin=protoc-gen-grpc=tools/macosx_x64/grpc_c
sharp_plugin
```