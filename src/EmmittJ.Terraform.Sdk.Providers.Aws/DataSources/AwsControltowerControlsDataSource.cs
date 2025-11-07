using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_controltower_controls.
/// </summary>
public class AwsControltowerControlsDataSource : TerraformDataSource
{
    public AwsControltowerControlsDataSource(string name) : base("aws_controltower_controls", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("enabled_controls");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The target_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_identifier");
        set => this.WithProperty("target_identifier", value);
    }

    /// <summary>
    /// The enabled_controls attribute.
    /// </summary>
    public TerraformExpression EnabledControls => this["enabled_controls"];

}
