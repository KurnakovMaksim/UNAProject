﻿// <copyright file="ToDoItemMarkComplete.cs" company="linkprada">
// Copyright (c) linkprada. All rights reserved.
// </copyright>

using System.Linq;
using Xunit;

namespace UNAProject.UnitTests.Core.ProjectAggregate
{
    public class ToDoItemMarkComplete
    {
        [Fact]
        public void SetsIsDoneToTrue()
        {
            var item = new ToDoItemBuilder()
                .WithDefaultValues()
                .Description("")
                .Build();

            item.MarkComplete();

            Assert.True(item.IsDone);
        }
    }
}
