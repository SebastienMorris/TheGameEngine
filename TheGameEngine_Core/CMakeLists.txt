cmake_minimum_required(VERSION 3.20)
project(TheGameEngine_Core)

set(CMAKE_CXX_STANDARD 20)

add_library(TheGameEngine_Core SHARED Library_EngineCore.cpp)

add_custom_command(TARGET TheGameEngine_Core POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E copy
    $<TARGET_FILE:TheGameEngine_Core>
        "${CMAKE_SOURCE_DIR}/../TheGameEngine_Interface/TheGameEngine_Interface/bin/Debug/net10.0-windows/"
)