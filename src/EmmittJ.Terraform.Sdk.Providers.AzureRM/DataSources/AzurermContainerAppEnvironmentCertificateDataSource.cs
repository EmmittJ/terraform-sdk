using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_container_app_environment_certificate.
/// </summary>
public class AzurermContainerAppEnvironmentCertificateDataSource : TerraformDataSource
{
    public AzurermContainerAppEnvironmentCertificateDataSource(string name) : base("azurerm_container_app_environment_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("expiration_date");
        this.DeclareOutput("issue_date");
        this.DeclareOutput("issuer");
        this.DeclareOutput("subject_name");
        this.DeclareOutput("tags");
        this.DeclareOutput("thumbprint");
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Certificate on.
    /// </summary>
    public TerraformProperty<string>? ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("container_app_environment_id");
        set => this.WithProperty("container_app_environment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name of the Container Apps Certificate.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The Thumbprint of the Certificate.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

}
