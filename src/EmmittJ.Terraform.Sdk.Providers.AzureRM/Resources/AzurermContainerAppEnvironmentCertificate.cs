using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_app_environment_certificate resource.
/// </summary>
public class AzurermContainerAppEnvironmentCertificate : TerraformResource
{
    public AzurermContainerAppEnvironmentCertificate(string name) : base("azurerm_container_app_environment_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("expiration_date");
        this.DeclareOutput("issue_date");
        this.DeclareOutput("issuer");
        this.DeclareOutput("subject_name");
        this.DeclareOutput("thumbprint");
    }

    /// <summary>
    /// The Certificate Private Key as a base64 encoded PFX or PEM.
    /// </summary>
    public string? CertificateBlobBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_blob_base64")?.Value;
        set => this.WithProperty("certificate_blob_base64", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password for the Certificate.
    /// </summary>
    public string? CertificatePassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_password")?.Value;
        set => this.WithProperty("certificate_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Certificate on.
    /// </summary>
    public string? ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_app_environment_id")?.Value;
        set => this.WithProperty("container_app_environment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the Container Apps Environment Certificate.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The expiration date for the Certificate.
    /// </summary>
    public TerraformExpression ExpirationDate => this["expiration_date"];

    /// <summary>
    /// The date of issue for the Certificate.
    /// </summary>
    public TerraformExpression IssueDate => this["issue_date"];

    /// <summary>
    /// The Certificate Issuer.
    /// </summary>
    public TerraformExpression Issuer => this["issuer"];

    /// <summary>
    /// The Subject Name for the Certificate.
    /// </summary>
    public TerraformExpression SubjectName => this["subject_name"];

    /// <summary>
    /// The Thumbprint of the Certificate.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

}
