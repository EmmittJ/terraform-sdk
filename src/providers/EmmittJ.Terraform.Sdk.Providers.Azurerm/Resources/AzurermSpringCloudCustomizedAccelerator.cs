using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for git_repository in AzurermSpringCloudCustomizedAccelerator.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "git_repository";

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformValue<string>? Branch
    {
        get => GetArgument<TerraformValue<string>>("branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    public TerraformValue<string>? CaCertificateId
    {
        get => GetArgument<TerraformValue<string>>("ca_certificate_id");
        set => SetArgument("ca_certificate_id", value);
    }

    /// <summary>
    /// The commit attribute.
    /// </summary>
    public TerraformValue<string>? Commit
    {
        get => GetArgument<TerraformValue<string>>("commit");
        set => SetArgument("commit", value);
    }

    /// <summary>
    /// The git_tag attribute.
    /// </summary>
    public TerraformValue<string>? GitTag
    {
        get => GetArgument<TerraformValue<string>>("git_tag");
        set => SetArgument("git_tag", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? IntervalInSeconds
    {
        get => GetArgument<TerraformValue<double>>("interval_in_seconds");
        set => SetArgument("interval_in_seconds", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// BasicAuth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicAuth block(s) allowed")]
    public TerraformList<AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlockBasicAuthBlock>? BasicAuth
    {
        get => GetArgument<TerraformList<AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlockBasicAuthBlock>>("basic_auth");
        set => SetArgument("basic_auth", value);
    }

    /// <summary>
    /// SshAuth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SshAuth block(s) allowed")]
    public TerraformList<AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlockSshAuthBlock>? SshAuth
    {
        get => GetArgument<TerraformList<AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlockSshAuthBlock>>("ssh_auth");
        set => SetArgument("ssh_auth", value);
    }

}

/// <summary>
/// Block type for basic_auth in AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlockBasicAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic_auth";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for ssh_auth in AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlockSshAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_auth";

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    public TerraformValue<string>? HostKey
    {
        get => GetArgument<TerraformValue<string>>("host_key");
        set => SetArgument("host_key", value);
    }

    /// <summary>
    /// The host_key_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? HostKeyAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("host_key_algorithm");
        set => SetArgument("host_key_algorithm", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    public required TerraformValue<string> PrivateKey
    {
        get => GetArgument<TerraformValue<string>>("private_key");
        set => SetArgument("private_key", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSpringCloudCustomizedAccelerator.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudCustomizedAcceleratorTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_spring_cloud_customized_accelerator Terraform resource.
/// Manages a azurerm_spring_cloud_customized_accelerator resource.
/// </summary>
public partial class AzurermSpringCloudCustomizedAccelerator(string name) : TerraformResource("azurerm_spring_cloud_customized_accelerator", name)
{
    /// <summary>
    /// The accelerator_tags attribute.
    /// </summary>
    public TerraformList<string>? AcceleratorTags
    {
        get => GetArgument<TerraformList<string>>("accelerator_tags");
        set => SetArgument("accelerator_tags", value);
    }

    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    public TerraformValue<string>? AcceleratorType
    {
        get => GetArgument<TerraformValue<string>>("accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    public TerraformValue<string>? IconUrl
    {
        get => GetArgument<TerraformValue<string>>("icon_url");
        set => SetArgument("icon_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The spring_cloud_accelerator_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAcceleratorId is required")]
    public required TerraformValue<string> SpringCloudAcceleratorId
    {
        get => GetArgument<TerraformValue<string>>("spring_cloud_accelerator_id");
        set => SetArgument("spring_cloud_accelerator_id", value);
    }

    /// <summary>
    /// GitRepository block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GitRepository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GitRepository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    public required TerraformList<AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock> GitRepository
    {
        get => GetRequiredArgument<TerraformList<AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock>>("git_repository");
        set => SetArgument("git_repository", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudCustomizedAcceleratorTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudCustomizedAcceleratorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
