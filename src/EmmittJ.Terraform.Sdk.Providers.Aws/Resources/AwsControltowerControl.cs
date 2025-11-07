using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_controltower_control resource.
/// </summary>
public class AwsControltowerControl : TerraformResource
{
    public AwsControltowerControl(string name) : base("aws_controltower_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The control_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ControlIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("control_identifier");
        set => this.WithProperty("control_identifier", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The target_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? TargetIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("target_identifier");
        set => this.WithProperty("target_identifier", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
