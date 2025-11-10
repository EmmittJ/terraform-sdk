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
        SetOutput("id");
        SetOutput("status");
        SetOutput("delegated_admin_account");
        SetOutput("deregister_on_destroy");
        SetOutput("kms_key");
        SetOutput("region");
    }

    /// <summary>
    /// The delegated_admin_account attribute.
    /// </summary>
    public TerraformProperty<string> DelegatedAdminAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delegated_admin_account");
        set => SetProperty("delegated_admin_account", value);
    }

    /// <summary>
    /// The deregister_on_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> DeregisterOnDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deregister_on_destroy");
        set => SetProperty("deregister_on_destroy", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformProperty<string> KmsKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key");
        set => SetProperty("kms_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
