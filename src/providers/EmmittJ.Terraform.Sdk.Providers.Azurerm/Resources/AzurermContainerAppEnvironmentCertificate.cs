using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermContainerAppEnvironmentCertificate.
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentCertificateTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_container_app_environment_certificate Terraform resource.
/// Manages a azurerm_container_app_environment_certificate resource.
/// </summary>
public partial class AzurermContainerAppEnvironmentCertificate(string name) : TerraformResource("azurerm_container_app_environment_certificate", name)
{
    /// <summary>
    /// The Certificate Private Key as a base64 encoded PFX or PEM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateBlobBase64 is required")]
    public required TerraformValue<string> CertificateBlobBase64
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_blob_base64");
        set => SetArgument("certificate_blob_base64", value);
    }

    /// <summary>
    /// The password for the Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificatePassword is required")]
    public required TerraformValue<string> CertificatePassword
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_password");
        set => SetArgument("certificate_password", value);
    }

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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Container Apps Environment Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The expiration date for the Certificate.
    /// </summary>
    public TerraformValue<string> ExpirationDate
        => AsReference("expiration_date");

    /// <summary>
    /// The date of issue for the Certificate.
    /// </summary>
    public TerraformValue<string> IssueDate
        => AsReference("issue_date");

    /// <summary>
    /// The Certificate Issuer.
    /// </summary>
    public TerraformValue<string> Issuer
        => AsReference("issuer");

    /// <summary>
    /// The Subject Name for the Certificate.
    /// </summary>
    public TerraformValue<string> SubjectName
        => AsReference("subject_name");

    /// <summary>
    /// The Thumbprint of the Certificate.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerAppEnvironmentCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerAppEnvironmentCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
