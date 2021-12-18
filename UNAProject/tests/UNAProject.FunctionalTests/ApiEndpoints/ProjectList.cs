﻿// <copyright file="ProjectList.cs" company="linkprada">
// Copyright (c) linkprada. All rights reserved.
// </copyright>

using System.Net.Http;
using System.Threading.Tasks;
using Ardalis.HttpClientTestExtensions;
using UNAProject.Web;
using UNAProject.Web.Endpoints.ProjectEndpoints;
using Xunit;

namespace UNAProject.FunctionalTests.ApiEndpoints
{
    [Collection("Sequential")]
    public class ProjectList : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public ProjectList(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnsOneProject()
        {
            var result = await _client.GetAndDeserialize<ProjectListResponse>("/Projects");

            Assert.Single(result.Projects);
            Assert.Contains(result.Projects, i => i.Name == SeedData.TestProject1.Name);
        }
    }
}
