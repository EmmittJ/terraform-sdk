using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for repository in AzurermSpringCloudConfigurationService.
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
    public TerraformValue<string>? CaCertificateId
    {
        get => GetArgument<TerraformValue<string>>("ca_certificate_id");
        set => SetArgument("ca_certificate_id", value);
    }

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
    /// The label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Label is required")]
    public required TerraformValue<string> Label
    {
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
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
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The patterns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Patterns is required")]
    public required TerraformSet<string> Patterns
    {
        get => GetArgument<TerraformSet<string>>("patterns");
        set => SetArgument("patterns", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformValue<string>? PrivateKey
    {
        get => GetArgument<TerraformValue<string>>("private_key");
        set => SetArgument("private_key", value);
    }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    public TerraformSet<string>? SearchPaths
    {
        get => GetArgument<TerraformSet<string>>("search_paths");
        set => SetArgument("search_paths", value);
    }

    /// <summary>
    /// The strict_host_key_checking attribute.
    /// </summary>
    public TerraformValue<bool>? StrictHostKeyChecking
    {
        get => GetArgument<TerraformValue<bool>>("strict_host_key_checking");
        set => SetArgument("strict_host_key_checking", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSpringCloudConfigurationService.
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
/// Represents a azurerm_spring_cloud_configuration_service Terraform resource.
/// Manages a azurerm_spring_cloud_configuration_service resource.
/// </summary>
public partial class AzurermSpringCloudConfigurationService(string name) : TerraformResource("azurerm_spring_cloud_configuration_service", name)
{
    /// <summary>
    /// The generation attribute.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => GetArgument<TerraformValue<string>>("generation");
        set => SetArgument("generation", value);
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
    /// The refresh_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? RefreshIntervalInSeconds
    {
        get => GetArgument<TerraformValue<double>>("refresh_interval_in_seconds");
        set => SetArgument("refresh_interval_in_seconds", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformValue<string> SpringCloudServiceId
    {
        get => GetArgument<TerraformValue<string>>("spring_cloud_service_id");
        set => SetArgument("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Repository block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSpringCloudConfigurationServiceRepositoryBlock>? Repository
    {
        get => GetArgument<TerraformList<AzurermSpringCloudConfigurationServiceRepositoryBlock>>("repository");
        set => SetArgument("repository", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudConfigurationServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudConfigurationServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
