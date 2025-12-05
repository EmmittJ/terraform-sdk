using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermContainerAppEnvironmentCertificateDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetRequiredArgument<TerraformValue<string>>("container_app_environment_id");
        set => SetArgument("container_app_environment_id", value);
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
    /// The name of the Container Apps Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The expiration date for the Certificate.
    /// </summary>
    public TerraformValue<string> ExpirationDate
        => CreateReference("expiration_date");

    /// <summary>
    /// The date of issue for the Certificate.
    /// </summary>
    public TerraformValue<string> IssueDate
        => CreateReference("issue_date");

    /// <summary>
    /// The Certificate Issuer.
    /// </summary>
    public TerraformValue<string> Issuer
        => CreateReference("issuer");

    /// <summary>
    /// The Subject Name for the Certificate.
    /// </summary>
    public TerraformValue<string> SubjectName
        => CreateReference("subject_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The Thumbprint of the Certificate.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => CreateReference("thumbprint");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerAppEnvironmentCertificateDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerAppEnvironmentCertificateDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
