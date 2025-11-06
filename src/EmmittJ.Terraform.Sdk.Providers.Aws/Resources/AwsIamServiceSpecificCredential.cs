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
        this.DeclareOutput("create_date");
        this.DeclareOutput("expiration_date");
        this.DeclareOutput("service_credential_alias");
        this.DeclareOutput("service_credential_secret");
        this.DeclareOutput("service_password");
        this.DeclareOutput("service_specific_credential_id");
        this.DeclareOutput("service_user_name");
    }

    /// <summary>
    /// The credential_age_days attribute.
    /// </summary>
    public double? CredentialAgeDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("credential_age_days")?.Value;
        set => this.WithProperty("credential_age_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The service_name attribute.
    /// </summary>
    public string? ServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_name")?.Value;
        set => this.WithProperty("service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public string? UserName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_name")?.Value;
        set => this.WithProperty("user_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
