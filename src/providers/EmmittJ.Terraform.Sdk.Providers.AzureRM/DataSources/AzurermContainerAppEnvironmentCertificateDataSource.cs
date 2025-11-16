using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentCertificateDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_container_app_environment_certificate Terraform data source.
/// Retrieves information about a azurerm_container_app_environment_certificate.
/// </summary>
public partial class AzurermContainerAppEnvironmentCertificateDataSource(string name) : TerraformDataSource("azurerm_container_app_environment_certificate", name)
{
    /// <summary>
    /// The Container App Managed Environment ID to configure this Certificate on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformValue<string> ContainerAppEnvironmentId
    {
        get => new TerraformReference<string>(this, "container_app_environment_id");
        set => SetArgument("container_app_environment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Container Apps Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The expiration date for the Certificate.
    /// </summary>
    public TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
    }

    /// <summary>
    /// The date of issue for the Certificate.
    /// </summary>
    public TerraformValue<string> IssueDate
    {
        get => new TerraformReference<string>(this, "issue_date");
    }

    /// <summary>
    /// The Certificate Issuer.
    /// </summary>
    public TerraformValue<string> Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
    }

    /// <summary>
    /// The Subject Name for the Certificate.
    /// </summary>
    public TerraformValue<string> SubjectName
    {
        get => new TerraformReference<string>(this, "subject_name");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The Thumbprint of the Certificate.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerAppEnvironmentCertificateDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerAppEnvironmentCertificateDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
