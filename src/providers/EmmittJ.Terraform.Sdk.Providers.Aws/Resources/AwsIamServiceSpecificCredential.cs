using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_service_specific_credential resource.
/// </summary>
public class AwsIamServiceSpecificCredential : TerraformResource
{
    public AwsIamServiceSpecificCredential(string name) : base("aws_iam_service_specific_credential", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_date");
        SetOutput("expiration_date");
        SetOutput("service_credential_alias");
        SetOutput("service_credential_secret");
        SetOutput("service_password");
        SetOutput("service_specific_credential_id");
        SetOutput("service_user_name");
        SetOutput("credential_age_days");
        SetOutput("id");
        SetOutput("service_name");
        SetOutput("status");
        SetOutput("user_name");
    }

    /// <summary>
    /// The credential_age_days attribute.
    /// </summary>
    public TerraformProperty<double> CredentialAgeDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("credential_age_days");
        set => SetProperty("credential_age_days", value);
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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_name");
        set => SetProperty("service_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_name");
        set => SetProperty("user_name", value);
    }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformExpression CreateDate => this["create_date"];

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformExpression ExpirationDate => this["expiration_date"];

    /// <summary>
    /// The service_credential_alias attribute.
    /// </summary>
    public TerraformExpression ServiceCredentialAlias => this["service_credential_alias"];

    /// <summary>
    /// The service_credential_secret attribute.
    /// </summary>
    public TerraformExpression ServiceCredentialSecret => this["service_credential_secret"];

    /// <summary>
    /// The service_password attribute.
    /// </summary>
    public TerraformExpression ServicePassword => this["service_password"];

    /// <summary>
    /// The service_specific_credential_id attribute.
    /// </summary>
    public TerraformExpression ServiceSpecificCredentialId => this["service_specific_credential_id"];

    /// <summary>
    /// The service_user_name attribute.
    /// </summary>
    public TerraformExpression ServiceUserName => this["service_user_name"];

}
