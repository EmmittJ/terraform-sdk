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
        get => GetProperty<TerraformProperty<bool>>("code_repository");
        set => WithProperty("code_repository", value);
    }

    /// <summary>
    /// The ec2 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2 is required")]
    public required TerraformProperty<bool> Ec2
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("ec2");
        set => WithProperty("ec2", value);
    }

    /// <summary>
    /// The ecr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ecr is required")]
    public required TerraformProperty<bool> Ecr
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("ecr");
        set => WithProperty("ecr", value);
    }

    /// <summary>
    /// The lambda attribute.
    /// </summary>
    public TerraformProperty<bool>? Lambda
    {
        get => GetProperty<TerraformProperty<bool>>("lambda");
        set => WithProperty("lambda", value);
    }

    /// <summary>
    /// The lambda_code attribute.
    /// </summary>
    public TerraformProperty<bool>? LambdaCode
    {
        get => GetProperty<TerraformProperty<bool>>("lambda_code");
        set => WithProperty("lambda_code", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.WithOutput("max_account_limit_reached");
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
    /// Block for auto_enable.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AutoEnable block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoEnable block(s) allowed")]
    public List<AwsInspector2OrganizationConfigurationAutoEnableBlock>? AutoEnable
    {
        get => GetProperty<List<AwsInspector2OrganizationConfigurationAutoEnableBlock>>("auto_enable");
        set => this.WithProperty("auto_enable", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsInspector2OrganizationConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsInspector2OrganizationConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The max_account_limit_reached attribute.
    /// </summary>
    public TerraformExpression MaxAccountLimitReached => this["max_account_limit_reached"];

}
