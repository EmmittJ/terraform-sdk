using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_account resource.
/// </summary>
public class AwsSecurityhubAccount : TerraformResource
{
    public AwsSecurityhubAccount(string name) : base("aws_securityhub_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The auto_enable_controls attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoEnableControls
    {
        get => GetProperty<TerraformProperty<bool>>("auto_enable_controls");
        set => this.WithProperty("auto_enable_controls", value);
    }

    /// <summary>
    /// The control_finding_generator attribute.
    /// </summary>
    public TerraformProperty<string>? ControlFindingGenerator
    {
        get => GetProperty<TerraformProperty<string>>("control_finding_generator");
        set => this.WithProperty("control_finding_generator", value);
    }

    /// <summary>
    /// The enable_default_standards attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableDefaultStandards
    {
        get => GetProperty<TerraformProperty<bool>>("enable_default_standards");
        set => this.WithProperty("enable_default_standards", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
