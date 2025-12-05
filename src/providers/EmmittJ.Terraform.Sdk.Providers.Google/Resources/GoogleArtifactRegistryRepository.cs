using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cleanup_policies in GoogleArtifactRegistryRepository.
/// Nesting mode: set
/// </summary>
public class GoogleArtifactRegistryRepositoryCleanupPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cleanup_policies";

    /// <summary>
    /// Policy action. Possible values: [&amp;quot;DELETE&amp;quot;, &amp;quot;KEEP&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryCleanupPoliciesBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryCleanupPoliciesBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// MostRecentVersions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MostRecentVersions block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryCleanupPoliciesBlockMostRecentVersionsBlock>? MostRecentVersions
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryCleanupPoliciesBlockMostRecentVersionsBlock>>("most_recent_versions");
        set => SetArgument("most_recent_versions", value);
    }

}

/// <summary>
/// Block type for condition in GoogleArtifactRegistryRepositoryCleanupPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryCleanupPoliciesBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// Match versions newer than a duration.
    /// </summary>
    public TerraformValue<string>? NewerThan
    {
        get => GetArgument<TerraformValue<string>>("newer_than");
        set => SetArgument("newer_than", value);
    }

    /// <summary>
    /// Match versions older than a duration.
    /// </summary>
    public TerraformValue<string>? OlderThan
    {
        get => GetArgument<TerraformValue<string>>("older_than");
        set => SetArgument("older_than", value);
    }

    /// <summary>
    /// Match versions by package prefix. Applied on any prefix match.
    /// </summary>
    public TerraformList<string>? PackageNamePrefixes
    {
        get => GetArgument<TerraformList<string>>("package_name_prefixes");
        set => SetArgument("package_name_prefixes", value);
    }

    /// <summary>
    /// Match versions by tag prefix. Applied on any prefix match.
    /// </summary>
    public TerraformList<string>? TagPrefixes
    {
        get => GetArgument<TerraformList<string>>("tag_prefixes");
        set => SetArgument("tag_prefixes", value);
    }

    /// <summary>
    /// Match versions by tag status. Default value: &amp;quot;ANY&amp;quot; Possible values: [&amp;quot;TAGGED&amp;quot;, &amp;quot;UNTAGGED&amp;quot;, &amp;quot;ANY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? TagState
    {
        get => GetArgument<TerraformValue<string>>("tag_state");
        set => SetArgument("tag_state", value);
    }

    /// <summary>
    /// Match versions by version name prefix. Applied on any prefix match.
    /// </summary>
    public TerraformList<string>? VersionNamePrefixes
    {
        get => GetArgument<TerraformList<string>>("version_name_prefixes");
        set => SetArgument("version_name_prefixes", value);
    }

}

/// <summary>
/// Block type for most_recent_versions in GoogleArtifactRegistryRepositoryCleanupPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryCleanupPoliciesBlockMostRecentVersionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "most_recent_versions";

    /// <summary>
    /// Minimum number of versions to keep.
    /// </summary>
    public TerraformValue<double>? KeepCount
    {
        get => GetArgument<TerraformValue<double>>("keep_count");
        set => SetArgument("keep_count", value);
    }

    /// <summary>
    /// Match versions by package prefix. Applied on any prefix match.
    /// </summary>
    public TerraformList<string>? PackageNamePrefixes
    {
        get => GetArgument<TerraformList<string>>("package_name_prefixes");
        set => SetArgument("package_name_prefixes", value);
    }

}


/// <summary>
/// Block type for docker_config in GoogleArtifactRegistryRepository.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryDockerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "docker_config";

    /// <summary>
    /// The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.
    /// </summary>
    public TerraformValue<bool>? ImmutableTags
    {
        get => GetArgument<TerraformValue<bool>>("immutable_tags");
        set => SetArgument("immutable_tags", value);
    }

}


/// <summary>
/// Block type for maven_config in GoogleArtifactRegistryRepository.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryMavenConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maven_config";

    /// <summary>
    /// The repository with this flag will allow publishing the same
    /// snapshot versions.
    /// </summary>
    public TerraformValue<bool>? AllowSnapshotOverwrites
    {
        get => GetArgument<TerraformValue<bool>>("allow_snapshot_overwrites");
        set => SetArgument("allow_snapshot_overwrites", value);
    }

    /// <summary>
    /// Version policy defines the versions that the registry will accept. Default value: &amp;quot;VERSION_POLICY_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;VERSION_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;RELEASE&amp;quot;, &amp;quot;SNAPSHOT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? VersionPolicy
    {
        get => GetArgument<TerraformValue<string>>("version_policy");
        set => SetArgument("version_policy", value);
    }

}


/// <summary>
/// Block type for remote_repository_config in GoogleArtifactRegistryRepository.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote_repository_config";

    /// <summary>
    /// The description of the remote source.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// If true, the remote repository upstream and upstream credentials will
    /// not be validated.
    /// </summary>
    public TerraformValue<bool>? DisableUpstreamValidation
    {
        get => GetArgument<TerraformValue<bool>>("disable_upstream_validation");
        set => SetArgument("disable_upstream_validation", value);
    }

    /// <summary>
    /// AptRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AptRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockAptRepositoryBlock>? AptRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockAptRepositoryBlock>>("apt_repository");
        set => SetArgument("apt_repository", value);
    }

    /// <summary>
    /// CommonRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommonRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockCommonRepositoryBlock>? CommonRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockCommonRepositoryBlock>>("common_repository");
        set => SetArgument("common_repository", value);
    }

    /// <summary>
    /// DockerRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockDockerRepositoryBlock>? DockerRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockDockerRepositoryBlock>>("docker_repository");
        set => SetArgument("docker_repository", value);
    }

    /// <summary>
    /// MavenRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MavenRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockMavenRepositoryBlock>? MavenRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockMavenRepositoryBlock>>("maven_repository");
        set => SetArgument("maven_repository", value);
    }

    /// <summary>
    /// NpmRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NpmRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockNpmRepositoryBlock>? NpmRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockNpmRepositoryBlock>>("npm_repository");
        set => SetArgument("npm_repository", value);
    }

    /// <summary>
    /// PythonRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PythonRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockPythonRepositoryBlock>? PythonRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockPythonRepositoryBlock>>("python_repository");
        set => SetArgument("python_repository", value);
    }

    /// <summary>
    /// UpstreamCredentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpstreamCredentials block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockUpstreamCredentialsBlock>? UpstreamCredentials
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockUpstreamCredentialsBlock>>("upstream_credentials");
        set => SetArgument("upstream_credentials", value);
    }

    /// <summary>
    /// YumRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 YumRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockYumRepositoryBlock>? YumRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockYumRepositoryBlock>>("yum_repository");
        set => SetArgument("yum_repository", value);
    }

}

/// <summary>
/// Block type for apt_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockAptRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "apt_repository";

    /// <summary>
    /// PublicRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockAptRepositoryBlockPublicRepositoryBlock>? PublicRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockAptRepositoryBlockPublicRepositoryBlock>>("public_repository");
        set => SetArgument("public_repository", value);
    }

}

/// <summary>
/// Block type for public_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockAptRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockAptRepositoryBlockPublicRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_repository";

    /// <summary>
    /// A common public repository base for Apt, e.g. &#39;&amp;quot;debian/dists/stable&amp;quot;&#39; Possible values: [&amp;quot;DEBIAN&amp;quot;, &amp;quot;UBUNTU&amp;quot;, &amp;quot;DEBIAN_SNAPSHOT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryBase is required")]
    public required TerraformValue<string> RepositoryBase
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_base");
        set => SetArgument("repository_base", value);
    }

    /// <summary>
    /// Specific repository from the base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryPath is required")]
    public required TerraformValue<string> RepositoryPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_path");
        set => SetArgument("repository_path", value);
    }

}

/// <summary>
/// Block type for common_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockCommonRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "common_repository";

    /// <summary>
    /// One of:
    /// a. Artifact Registry Repository resource, e.g. &#39;projects/UPSTREAM_PROJECT_ID/locations/REGION/repositories/UPSTREAM_REPOSITORY&#39;
    /// b. URI to the registry, e.g. &#39;&amp;quot;https://registry-1.docker.io&amp;quot;&#39;
    /// c. URI to Artifact Registry Repository, e.g. &#39;&amp;quot;https://REGION-docker.pkg.dev/UPSTREAM_PROJECT_ID/UPSTREAM_REPOSITORY&amp;quot;&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for docker_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockDockerRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "docker_repository";

    /// <summary>
    /// Address of the remote repository. Possible values: [&amp;quot;DOCKER_HUB&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PublicRepository
    {
        get => GetArgument<TerraformValue<string>>("public_repository");
        set => SetArgument("public_repository", value);
    }

    /// <summary>
    /// CustomRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockDockerRepositoryBlockCustomRepositoryBlock>? CustomRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockDockerRepositoryBlockCustomRepositoryBlock>>("custom_repository");
        set => SetArgument("custom_repository", value);
    }

}

/// <summary>
/// Block type for custom_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockDockerRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockDockerRepositoryBlockCustomRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_repository";

    /// <summary>
    /// Specific uri to the registry, e.g. &#39;&amp;quot;https://registry-1.docker.io&amp;quot;&#39;
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for maven_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockMavenRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maven_repository";

    /// <summary>
    /// Address of the remote repository. Possible values: [&amp;quot;MAVEN_CENTRAL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PublicRepository
    {
        get => GetArgument<TerraformValue<string>>("public_repository");
        set => SetArgument("public_repository", value);
    }

    /// <summary>
    /// CustomRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockMavenRepositoryBlockCustomRepositoryBlock>? CustomRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockMavenRepositoryBlockCustomRepositoryBlock>>("custom_repository");
        set => SetArgument("custom_repository", value);
    }

}

/// <summary>
/// Block type for custom_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockMavenRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockMavenRepositoryBlockCustomRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_repository";

    /// <summary>
    /// Specific uri to the registry, e.g. &#39;&amp;quot;https://repo.maven.apache.org/maven2&amp;quot;&#39;
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for npm_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockNpmRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "npm_repository";

    /// <summary>
    /// Address of the remote repository. Possible values: [&amp;quot;NPMJS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PublicRepository
    {
        get => GetArgument<TerraformValue<string>>("public_repository");
        set => SetArgument("public_repository", value);
    }

    /// <summary>
    /// CustomRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockNpmRepositoryBlockCustomRepositoryBlock>? CustomRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockNpmRepositoryBlockCustomRepositoryBlock>>("custom_repository");
        set => SetArgument("custom_repository", value);
    }

}

/// <summary>
/// Block type for custom_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockNpmRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockNpmRepositoryBlockCustomRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_repository";

    /// <summary>
    /// Specific uri to the registry, e.g. &#39;&amp;quot;https://registry.npmjs.org&amp;quot;&#39;
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for python_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockPythonRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "python_repository";

    /// <summary>
    /// Address of the remote repository. Possible values: [&amp;quot;PYPI&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PublicRepository
    {
        get => GetArgument<TerraformValue<string>>("public_repository");
        set => SetArgument("public_repository", value);
    }

    /// <summary>
    /// CustomRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockPythonRepositoryBlockCustomRepositoryBlock>? CustomRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockPythonRepositoryBlockCustomRepositoryBlock>>("custom_repository");
        set => SetArgument("custom_repository", value);
    }

}

/// <summary>
/// Block type for custom_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockPythonRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockPythonRepositoryBlockCustomRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_repository";

    /// <summary>
    /// Specific uri to the registry, e.g. &#39;&amp;quot;https://pypi.io&amp;quot;&#39;
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for upstream_credentials in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockUpstreamCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upstream_credentials";

    /// <summary>
    /// UsernamePasswordCredentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UsernamePasswordCredentials block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockUpstreamCredentialsBlockUsernamePasswordCredentialsBlock>? UsernamePasswordCredentials
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockUpstreamCredentialsBlockUsernamePasswordCredentialsBlock>>("username_password_credentials");
        set => SetArgument("username_password_credentials", value);
    }

}

/// <summary>
/// Block type for username_password_credentials in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockUpstreamCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockUpstreamCredentialsBlockUsernamePasswordCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "username_password_credentials";

    /// <summary>
    /// The Secret Manager key version that holds the password to access the
    /// remote repository. Must be in the format of
    /// &#39;projects/{project}/secrets/{secret}/versions/{version}&#39;.
    /// </summary>
    public TerraformValue<string>? PasswordSecretVersion
    {
        get => GetArgument<TerraformValue<string>>("password_secret_version");
        set => SetArgument("password_secret_version", value);
    }

    /// <summary>
    /// The username to access the remote repository.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for yum_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockYumRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "yum_repository";

    /// <summary>
    /// PublicRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicRepository block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockYumRepositoryBlockPublicRepositoryBlock>? PublicRepository
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockYumRepositoryBlockPublicRepositoryBlock>>("public_repository");
        set => SetArgument("public_repository", value);
    }

}

/// <summary>
/// Block type for public_repository in GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockYumRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlockYumRepositoryBlockPublicRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_repository";

    /// <summary>
    /// A common public repository base for Yum. Possible values: [&amp;quot;CENTOS&amp;quot;, &amp;quot;CENTOS_DEBUG&amp;quot;, &amp;quot;CENTOS_VAULT&amp;quot;, &amp;quot;CENTOS_STREAM&amp;quot;, &amp;quot;ROCKY&amp;quot;, &amp;quot;EPEL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryBase is required")]
    public required TerraformValue<string> RepositoryBase
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_base");
        set => SetArgument("repository_base", value);
    }

    /// <summary>
    /// Specific repository from the base, e.g. &#39;&amp;quot;pub/rocky/9/BaseOS/x86_64/os&amp;quot;&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryPath is required")]
    public required TerraformValue<string> RepositoryPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_path");
        set => SetArgument("repository_path", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleArtifactRegistryRepository.
/// Nesting mode: single
/// </summary>
public class GoogleArtifactRegistryRepositoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for virtual_repository_config in GoogleArtifactRegistryRepository.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_repository_config";

    /// <summary>
    /// UpstreamPolicies block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlockUpstreamPoliciesBlock>? UpstreamPolicies
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlockUpstreamPoliciesBlock>>("upstream_policies");
        set => SetArgument("upstream_policies", value);
    }

}

/// <summary>
/// Block type for upstream_policies in GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlockUpstreamPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upstream_policies";

    /// <summary>
    /// The user-provided ID of the upstream policy.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Entries with a greater priority value take precedence in the pull order.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// A reference to the repository resource, for example:
    /// &amp;quot;projects/p1/locations/us-central1/repository/repo1&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Repository
    {
        get => GetArgument<TerraformValue<string>>("repository");
        set => SetArgument("repository", value);
    }

}


/// <summary>
/// Block type for vulnerability_scanning_config in GoogleArtifactRegistryRepository.
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryVulnerabilityScanningConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vulnerability_scanning_config";

    /// <summary>
    /// This configures whether vulnerability scanning is automatically performed for artifacts pushed to this repository. Possible values: [&amp;quot;INHERITED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EnablementConfig
    {
        get => GetArgument<TerraformValue<string>>("enablement_config");
        set => SetArgument("enablement_config", value);
    }

    /// <summary>
    /// This field returns whether scanning is active for this repository.
    /// </summary>
    public TerraformValue<string> EnablementState
        => CreateReference("enablement_state");

    /// <summary>
    /// This provides an explanation for the state of scanning on this repository.
    /// </summary>
    public TerraformValue<string> EnablementStateReason
        => CreateReference("enablement_state_reason");

}


/// <summary>
/// Represents a google_artifact_registry_repository Terraform resource.
/// Manages a google_artifact_registry_repository resource.
/// </summary>
public partial class GoogleArtifactRegistryRepository(string name) : TerraformResource("google_artifact_registry_repository", name)
{
    /// <summary>
    /// If true, the cleanup pipeline is prevented from deleting versions in this
    /// repository.
    /// </summary>
    public TerraformValue<bool>? CleanupPolicyDryRun
    {
        get => GetArgument<TerraformValue<bool>>("cleanup_policy_dry_run");
        set => SetArgument("cleanup_policy_dry_run", value);
    }

    /// <summary>
    /// The user-provided description of the repository.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The format of packages that are stored in the repository. Supported formats
    /// can be found [here](https://cloud.google.com/artifact-registry/docs/supported-formats).
    /// You can only create alpha formats if you are a member of the
    /// [alpha user group](https://cloud.google.com/artifact-registry/docs/supported-formats#alpha-access).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => GetRequiredArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The Cloud KMS resource name of the customer managed encryption key that’s
    /// used to encrypt the contents of the Repository. Has the form:
    /// &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;.
    /// This value may not be changed after the Repository has been created.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Labels with user-defined metadata.
    /// This field may contain up to 64 entries. Label keys and values may be no
    /// longer than 63 characters. Label keys must begin with a lowercase letter
    /// and may only contain lowercase letters, numeric characters, underscores,
    /// and dashes.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name of the repository&#39;s location. In addition to specific regions,
    /// special values for multi-region locations are &#39;asia&#39;, &#39;europe&#39;, and &#39;us&#39;.
    /// See [here](https://cloud.google.com/artifact-registry/docs/repositories/repo-locations),
    /// or use the
    /// [google_artifact_registry_locations](https://registry.terraform.io/providers/hashicorp/google/latest/docs/data-sources/artifact_registry_locations)
    /// data source for possible values.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location") ?? CreateReference("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mode configures the repository to serve artifacts from different sources. Default value: &amp;quot;STANDARD_REPOSITORY&amp;quot; Possible values: [&amp;quot;STANDARD_REPOSITORY&amp;quot;, &amp;quot;VIRTUAL_REPOSITORY&amp;quot;, &amp;quot;REMOTE_REPOSITORY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The last part of the repository name, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformValue<string> RepositoryId
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_id");
        set => SetArgument("repository_id", value);
    }

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The name of the repository, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The repository endpoint, for example: us-docker.pkg.dev/my-proj/my-repo.
    /// </summary>
    public TerraformValue<string> RegistryUri
        => CreateReference("registry_uri");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// The time when the repository was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// CleanupPolicies block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleArtifactRegistryRepositoryCleanupPoliciesBlock>? CleanupPolicies
    {
        get => GetArgument<TerraformSet<GoogleArtifactRegistryRepositoryCleanupPoliciesBlock>>("cleanup_policies");
        set => SetArgument("cleanup_policies", value);
    }

    /// <summary>
    /// DockerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerConfig block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryDockerConfigBlock>? DockerConfig
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryDockerConfigBlock>>("docker_config");
        set => SetArgument("docker_config", value);
    }

    /// <summary>
    /// MavenConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MavenConfig block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryMavenConfigBlock>? MavenConfig
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryMavenConfigBlock>>("maven_config");
        set => SetArgument("maven_config", value);
    }

    /// <summary>
    /// RemoteRepositoryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteRepositoryConfig block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock>? RemoteRepositoryConfig
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock>>("remote_repository_config");
        set => SetArgument("remote_repository_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleArtifactRegistryRepositoryTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleArtifactRegistryRepositoryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VirtualRepositoryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualRepositoryConfig block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlock>? VirtualRepositoryConfig
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlock>>("virtual_repository_config");
        set => SetArgument("virtual_repository_config", value);
    }

    /// <summary>
    /// VulnerabilityScanningConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VulnerabilityScanningConfig block(s) allowed")]
    public TerraformList<GoogleArtifactRegistryRepositoryVulnerabilityScanningConfigBlock>? VulnerabilityScanningConfig
    {
        get => GetArgument<TerraformList<GoogleArtifactRegistryRepositoryVulnerabilityScanningConfigBlock>>("vulnerability_scanning_config");
        set => SetArgument("vulnerability_scanning_config", value);
    }

}
