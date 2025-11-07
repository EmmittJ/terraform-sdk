using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_instance_state resource.
/// </summary>
public class AwsRdsInstanceState : TerraformResource
{
    public AwsRdsInstanceState(string name) : base("aws_rds_instance_state", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Identifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier");
        set => this.WithProperty("identifier", value);
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
    /// The state attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

}
