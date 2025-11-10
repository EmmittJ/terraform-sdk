using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_parameter in .
/// Nesting mode: set
/// </summary>
public class AwsConfigOrganizationConformancePackInputParameterBlock : TerraformBlock
{
    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    public required TerraformProperty<string> ParameterName
    {
        set => SetProperty("parameter_name", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformProperty<string> ParameterValue
    {
        set => SetProperty("parameter_value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsConfigOrganizationConformancePackTimeoutsBlock : TerraformBlock
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
/// Manages a aws_config_organization_conformance_pack resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConfigOrganizationConformancePack : TerraformResource
{
    public AwsConfigOrganizationConformancePack(string name) : base("aws_config_organization_conformance_pack", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("delivery_s3_bucket");
        SetOutput("delivery_s3_key_prefix");
        SetOutput("excluded_accounts");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("template_body");
        SetOutput("template_s3_uri");
    }

    /// <summary>
    /// The delivery_s3_bucket attribute.
    /// </summary>
    public TerraformProperty<string> DeliveryS3Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delivery_s3_bucket");
        set => SetProperty("delivery_s3_bucket", value);
    }

    /// <summary>
    /// The delivery_s3_key_prefix attribute.
    /// </summary>
    public TerraformProperty<string> DeliveryS3KeyPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delivery_s3_key_prefix");
        set => SetProperty("delivery_s3_key_prefix", value);
    }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ExcludedAccounts
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("excluded_accounts");
        set => SetProperty("excluded_accounts", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The template_body attribute.
    /// </summary>
    public TerraformProperty<string> TemplateBody
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_body");
        set => SetProperty("template_body", value);
    }

    /// <summary>
    /// The template_s3_uri attribute.
    /// </summary>
    public TerraformProperty<string> TemplateS3Uri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_s3_uri");
        set => SetProperty("template_s3_uri", value);
    }

    /// <summary>
    /// Block for input_parameter.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(60, ErrorMessage = "Maximum 60 InputParameter block(s) allowed")]
    public HashSet<AwsConfigOrganizationConformancePackInputParameterBlock>? InputParameter
    {
        set => SetProperty("input_parameter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsConfigOrganizationConformancePackTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
