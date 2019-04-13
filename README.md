# Benchmark-Middleware
a simple .NET Core piece of middle-ware to measure the total amount of time on a request, sizeof, max, min, and average of requests.

## Automation
| Metric        | Status           |
| :-------------: |:-------------:|
| VS2017     | [![Build Status](https://michaelearlallen.visualstudio.com/Benchmark%20MiddleWare/_apis/build/status/Benchmark%20MiddleWare-CI?branchName=master&jobName=VS2017%20Build)](https://michaelearlallen.visualstudio.com/Benchmark%20MiddleWare/_build/latest?definitionId=3&branchName=master) |
| Ubuntu 1604      | [![Build Status](https://michaelearlallen.visualstudio.com/Benchmark%20MiddleWare/_apis/build/status/Benchmark%20MiddleWare-CI?branchName=master&jobName=Ubuntu%201604%20Build)](https://michaelearlallen.visualstudio.com/Benchmark%20MiddleWare/_build/latest?definitionId=3&branchName=master)      |
| Windows Container | [![Build Status](https://michaelearlallen.visualstudio.com/Benchmark%20MiddleWare/_apis/build/status/Benchmark%20MiddleWare-CI?branchName=master&jobName=Windows%20Container%20Build)](https://michaelearlallen.visualstudio.com/Benchmark%20MiddleWare/_build/latest?definitionId=3&branchName=master)      |

## Getting started 

### main project 
run `scripts/build.sh/cmd` depending on platform.
### Sample Application
1) run `scripts/pack.sh/cmd` to package locally (will create output folder `Packages` which is gitignored).
2) run `scripts/build-sample.sh/cmd` to build the sample app under `src/sample-app`
3) run `scripts/deploy-sample.sh/cmd` to run the sample app locally (will use port 1001)
4) ??? 
5) Profit

### Integration Tests
tbd
