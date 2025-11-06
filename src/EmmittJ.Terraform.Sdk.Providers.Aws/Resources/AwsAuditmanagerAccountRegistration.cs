using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_auditmanager_account_registration resource.
/// </summary>
public class AwsAuditmanagerAccountRegistration : TerraformResource
{
    public AwsAuditmanagerAccountRegistration(string name) : base("aws_auditmanager_account_registration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The delegated_admin_account attribute.
    /// </summary>
    public string? DelegatedAdminAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delegated_admin_account")?.Value;
        set => this.WithProperty("delegated_admin_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deregister_on_destroy attribute.
    /// </summary>
    public bool? DeregisterOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deregister_on_destroy")?.Value;
        set => this.WithProperty("deregister_on_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public string? KmsKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key")?.Value;
        set => this.WithProperty("kms_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
