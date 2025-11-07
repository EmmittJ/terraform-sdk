using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_auditmanager_framework_share resource.
/// </summary>
public class AwsAuditmanagerFrameworkShare : TerraformResource
{
    public AwsAuditmanagerFrameworkShare(string name) : base("aws_auditmanager_framework_share", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Comment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("comment");
        set => this.WithProperty("comment", value);
    }

    /// <summary>
    /// The destination_account attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_account");
        set => this.WithProperty("destination_account", value);
    }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_region");
        set => this.WithProperty("destination_region", value);
    }

    /// <summary>
    /// The framework_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FrameworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("framework_id");
        set => this.WithProperty("framework_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
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
