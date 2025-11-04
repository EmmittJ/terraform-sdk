using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssoadmin_instance_access_control_attributes resource.
/// </summary>
public class AwsSsoadminInstanceAccessControlAttributes : TerraformResource
{
    public AwsSsoadminInstanceAccessControlAttributes(string name) : base("aws_ssoadmin_instance_access_control_attributes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
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
    /// The instance_arn attribute.
    /// </summary>
    public string? InstanceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_arn")?.Value;
        set => this.WithProperty("instance_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

}
