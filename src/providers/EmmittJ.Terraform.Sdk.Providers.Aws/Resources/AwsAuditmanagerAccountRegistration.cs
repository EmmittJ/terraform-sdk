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
        this.WithOutput("id");
        this.WithOutput("status");
    }

    /// <summary>
    /// The delegated_admin_account attribute.
    /// </summary>
    public TerraformProperty<string>? DelegatedAdminAccount
    {
        get => GetProperty<TerraformProperty<string>>("delegated_admin_account");
        set => this.WithProperty("delegated_admin_account", value);
    }

    /// <summary>
    /// The deregister_on_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? DeregisterOnDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("deregister_on_destroy");
        set => this.WithProperty("deregister_on_destroy", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => this.WithProperty("kms_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
