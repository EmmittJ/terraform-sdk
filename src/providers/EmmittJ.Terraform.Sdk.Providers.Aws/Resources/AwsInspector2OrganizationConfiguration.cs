using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_enable in .
/// Nesting mode: list
/// </summary>
public class AwsInspector2OrganizationConfigurationAutoEnableBlock : TerraformBlock
{
    /// <summary>
    /// The code_repository attribute.
    /// </summary>
    public TerraformProperty<bool>? CodeRepository
    {
        set => SetProperty("code_repository", value);
    }

    /// <summary>
    /// The ec2 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2 is required")]
    public required TerraformProperty<bool> Ec2
    {
        set => SetProperty("ec2", value);
    }

    /// <summary>
    /// The ecr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ecr is required")]
    public required TerraformProperty<bool> Ecr
    {
        set => SetProperty("ecr", value);
    }

    /// <summary>
    /// The lambda attribute.
    /// </summary>
    public TerraformProperty<bool>? Lambda
    {
        set => SetProperty("lambda", value);
    }

    /// <summary>
    /// The lambda_code attribute.
    /// </summary>
    public TerraformProperty<bool>? LambdaCode
    {
        set => SetProperty("lambda_code", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsInspector2OrganizationConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_inspector2_organization_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsInspector2OrganizationConfiguration : TerraformResource
{
    public AwsInspector2OrganizationConfiguration(string name) : base("aws_inspector2_organization_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("max_account_limit_reached");
        SetOutput("id");
        SetOutput("region");
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
    /// Block for auto_enable.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AutoEnable block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoEnable block(s) allowed")]
    public List<AwsInspector2OrganizationConfigurationAutoEnableBlock>? AutoEnable
    {
        set => SetProperty("auto_enable", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsInspector2OrganizationConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The max_account_limit_reached attribute.
    /// </summary>
    public TerraformExpression MaxAccountLimitReached => this["max_account_limit_reached"];

}
