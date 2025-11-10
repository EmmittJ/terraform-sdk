using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentCertificateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("expiration_date");
        SetOutput("issue_date");
        SetOutput("issuer");
        SetOutput("subject_name");
        SetOutput("thumbprint");
        SetOutput("certificate_blob_base64");
        SetOutput("certificate_password");
        SetOutput("container_app_environment_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("tags");
    }

    /// <summary>
    /// The Certificate Private Key as a base64 encoded PFX or PEM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateBlobBase64 is required")]
    public required TerraformProperty<string> CertificateBlobBase64
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_blob_base64");
        set => SetProperty("certificate_blob_base64", value);
    }

    /// <summary>
    /// The password for the Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificatePassword is required")]
    public required TerraformProperty<string> CertificatePassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_password");
        set => SetProperty("certificate_password", value);
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Certificate on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformProperty<string> ContainerAppEnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_app_environment_id");
        set => SetProperty("container_app_environment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name of the Container Apps Environment Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppEnvironmentCertificateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
