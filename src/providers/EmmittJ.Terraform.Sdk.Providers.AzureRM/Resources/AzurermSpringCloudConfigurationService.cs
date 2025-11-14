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
/// Block type for repository in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudConfigurationServiceRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repository";

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
    /// The host_key attribute.
    /// </summary>
    [TerraformArgument("host_key")]
    public TerraformValue<string>? HostKey
    {
        get => new TerraformReference<string>(this, "host_key");
        set => SetArgument("host_key", value);
    }

    /// <summary>
    /// The host_key_algorithm attribute.
    /// </summary>
    [TerraformArgument("host_key_algorithm")]
    public TerraformValue<string>? HostKeyAlgorithm
    {
        get => new TerraformReference<string>(this, "host_key_algorithm");
        set => SetArgument("host_key_algorithm", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Label is required")]
    [TerraformArgument("label")]
    public required TerraformValue<string> Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
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
    /// The password attribute.
    /// </summary>
    [TerraformArgument("password")]
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The patterns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Patterns is required")]
    [TerraformArgument("patterns")]
    public required TerraformSet<string> Patterns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "patterns").ResolveNodes(ctx));
        set => SetArgument("patterns", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformArgument("private_key")]
    public TerraformValue<string>? PrivateKey
    {
        get => new TerraformReference<string>(this, "private_key");
        set => SetArgument("private_key", value);
    }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    [TerraformArgument("search_paths")]
    public TerraformSet<string>? SearchPaths
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "search_paths").ResolveNodes(ctx));
        set => SetArgument("search_paths", value);
    }

    /// <summary>
    /// The strict_host_key_checking attribute.
    /// </summary>
    [TerraformArgument("strict_host_key_checking")]
    public TerraformValue<bool>? StrictHostKeyChecking
    {
        get => new TerraformReference<bool>(this, "strict_host_key_checking");
        set => SetArgument("strict_host_key_checking", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformArgument("uri")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformArgument("username")]
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudConfigurationServiceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_spring_cloud_configuration_service resource.
/// </summary>
public class AzurermSpringCloudConfigurationService : TerraformResource
{
    public AzurermSpringCloudConfigurationService(string name) : base("azurerm_spring_cloud_configuration_service", name)
    {
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    [TerraformArgument("generation")]
    public TerraformValue<string>? Generation
    {
        get => new TerraformReference<string>(this, "generation");
        set => SetArgument("generation", value);
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
    /// The refresh_interval_in_seconds attribute.
    /// </summary>
    [TerraformArgument("refresh_interval_in_seconds")]
    public TerraformValue<double>? RefreshIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "refresh_interval_in_seconds");
        set => SetArgument("refresh_interval_in_seconds", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformArgument("spring_cloud_service_id")]
    public required TerraformValue<string> SpringCloudServiceId
    {
        get => new TerraformReference<string>(this, "spring_cloud_service_id");
        set => SetArgument("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Block for repository.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("repository")]
    public TerraformList<AzurermSpringCloudConfigurationServiceRepositoryBlock> Repository { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudConfigurationServiceTimeoutsBlock Timeouts { get; set; } = new();

}
