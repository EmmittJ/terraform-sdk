using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeAwsLogSourceSourceBlock : TerraformBlock
{
    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Accounts
    {
        set => SetProperty("accounts", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regions is required")]
    public HashSet<TerraformProperty<string>>? Regions
    {
        set => SetProperty("regions", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformProperty<string> SourceName
    {
        set => SetProperty("source_name", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public TerraformProperty<string>? SourceVersion
    {
        set => SetProperty("source_version", value);
    }

}

/// <summary>
/// Manages a aws_securitylake_aws_log_source resource.
/// </summary>
public class AwsSecuritylakeAwsLogSource : TerraformResource
{
    public AwsSecuritylakeAwsLogSource(string name) : base("aws_securitylake_aws_log_source", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("region");
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
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSecuritylakeAwsLogSourceSourceBlock>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
