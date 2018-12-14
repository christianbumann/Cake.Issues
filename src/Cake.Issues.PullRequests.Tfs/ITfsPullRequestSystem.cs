﻿namespace Cake.Issues.PullRequests.Tfs
{
    using Cake.Tfs.PullRequest;

    /// <summary>
    /// Interface for writing issues to Team Foundation Server or Azure DevOps pull requests.
    /// </summary>
    internal interface ITfsPullRequestSystem : IPullRequestSystem
    {
        /// <summary>
        /// Gets information about the pull request.
        /// </summary>
        TfsPullRequest TfsPullRequest { get; }

        /// <summary>
        /// Validates if a pull request could be found.
        /// Depending on <see cref="TfsPullRequestSettings.ThrowExceptionIfPullRequestCouldNotBeFound"/>
        /// the pull request instance can be null for subsequent calls.
        /// </summary>
        /// <returns>True if a valid pull request instance exists.</returns>
        bool ValidatePullRequest();
    }
}
