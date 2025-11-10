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
        SetOutput("arn");
        SetOutput("auto_enable_controls");
        SetOutput("control_finding_generator");
        SetOutput("enable_default_standards");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The auto_enable_controls attribute.
    /// </summary>
    public TerraformProperty<bool> AutoEnableControls
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_enable_controls");
        set => SetProperty("auto_enable_controls", value);
    }

    /// <summary>
    /// The control_finding_generator attribute.
    /// </summary>
    public TerraformProperty<string> ControlFindingGenerator
    {
        get => GetRequiredOutput<TerraformProperty<string>>("control_finding_generator");
        set => SetProperty("control_finding_generator", value);
    }

    /// <summary>
    /// The enable_default_standards attribute.
    /// </summary>
    public TerraformProperty<bool> EnableDefaultStandards
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_default_standards");
        set => SetProperty("enable_default_standards", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
