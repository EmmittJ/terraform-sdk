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
        get => GetProperty<HashSet<TerraformProperty<string>>>("accounts");
        set => WithProperty("accounts", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regions is required")]
    public HashSet<TerraformProperty<string>>? Regions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("regions");
        set => WithProperty("regions", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformProperty<string> SourceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_name");
        set => WithProperty("source_name", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public TerraformProperty<string>? SourceVersion
    {
        get => GetProperty<TerraformProperty<string>>("source_version");
        set => WithProperty("source_version", value);
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
        this.DeclareOutput("id");
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
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSecuritylakeAwsLogSourceSourceBlock>? Source
    {
        get => GetProperty<List<AwsSecuritylakeAwsLogSourceSourceBlock>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
