using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for git_repository in .
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
    [TerraformArgument("branch")]
    public TerraformValue<string>? Branch
    {
        get => new TerraformReference<string>(this, "branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    [TerraformArgument("ca_certificate_id")]
    public TerraformValue<string>? CaCertificateId
    {
        get => new TerraformReference<string>(this, "ca_certificate_id");
        set => SetArgument("ca_certificate_id", value);
    }

    /// <summary>
    /// The commit attribute.
    /// </summary>
    [TerraformArgument("commit")]
    public TerraformValue<string>? Commit
    {
        get => new TerraformReference<string>(this, "commit");
        set => SetArgument("commit", value);
    }

    /// <summary>
    /// The git_tag attribute.
    /// </summary>
    [TerraformArgument("git_tag")]
    public TerraformValue<string>? GitTag
    {
        get => new TerraformReference<string>(this, "git_tag");
        set => SetArgument("git_tag", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [TerraformArgument("interval_in_seconds")]
    public TerraformValue<double>? IntervalInSeconds
    {
        get => new TerraformReference<double>(this, "interval_in_seconds");
        set => SetArgument("interval_in_seconds", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformArgument("path")]
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformArgument("url")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_spring_cloud_customized_accelerator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudCustomizedAccelerator : TerraformResource
{
    public AzurermSpringCloudCustomizedAccelerator(string name) : base("azurerm_spring_cloud_customized_accelerator", name)
    {
    }

    /// <summary>
    /// The accelerator_tags attribute.
    /// </summary>
    [TerraformArgument("accelerator_tags")]
    public TerraformList<string>? AcceleratorTags
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "accelerator_tags").ResolveNodes(ctx));
        set => SetArgument("accelerator_tags", value);
    }

    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    [TerraformArgument("accelerator_type")]
    public TerraformValue<string>? AcceleratorType
    {
        get => new TerraformReference<string>(this, "accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    [TerraformArgument("icon_url")]
    public TerraformValue<string>? IconUrl
    {
        get => new TerraformReference<string>(this, "icon_url");
        set => SetArgument("icon_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The spring_cloud_accelerator_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAcceleratorId is required")]
    [TerraformArgument("spring_cloud_accelerator_id")]
    public required TerraformValue<string> SpringCloudAcceleratorId
    {
        get => new TerraformReference<string>(this, "spring_cloud_accelerator_id");
        set => SetArgument("spring_cloud_accelerator_id", value);
    }

    /// <summary>
    /// Block for git_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GitRepository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GitRepository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    [TerraformArgument("git_repository")]
    public required TerraformList<AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock> GitRepository { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudCustomizedAcceleratorTimeoutsBlock Timeouts { get; set; } = new();

}
