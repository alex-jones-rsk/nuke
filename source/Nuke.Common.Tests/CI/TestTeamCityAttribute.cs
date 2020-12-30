// Copyright 2020 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.IO;
using System.Linq;
using Nuke.Common.CI.TeamCity;

namespace Nuke.Common.Tests.CI
{
    public class TestTeamCityConfigurationGenerator : TeamCityConfigurationGenerator, ITestConfigurationGenerator
    {
        public TestTeamCityConfigurationGenerator(TeamCityAgentPlatform platform)
            : base(platform)
        {
        }

        public StreamWriter Stream { get; set; }

        protected override StreamWriter CreateStream()
        {
            return Stream;
        }
    }
}
