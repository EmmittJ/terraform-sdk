using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssoadmin_permission_sets.
/// </summary>
public class AwsSsoadminPermissionSetsDataSource : TerraformDataSource
{
    public AwsSsoadminPermissionSetsDataSource(string name) : base("aws_ssoadmin_permission_sets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arns");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    public string? InstanceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_arn")?.Value;
        set => this.WithProperty("instance_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arns attribute.
    /// </summary>
    public TerraformExpression Arns => this["arns"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
