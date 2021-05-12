#!/bin/bash

rm -rf build
mkdir -p build
pushd build
cmake -DCMAKE_BUILD_TYPE=relwithdebinfo ..
popd
