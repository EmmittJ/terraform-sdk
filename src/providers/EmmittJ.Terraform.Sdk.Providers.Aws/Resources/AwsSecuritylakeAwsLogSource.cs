using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for source in AwsSecuritylakeAwsLogSource.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeAwsLogSourceSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformSet<string> Accounts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "accounts").ResolveNodes(ctx));
        set => SetArgument("accounts", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regions is required")]
    public required TerraformSet<string> Regions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "regions").ResolveNodes(ctx));
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformValue<string> SourceName
    {
        get => new TerraformReference<string>(this, "source_name");
        set => SetArgument("source_name", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public TerraformValue<string> SourceVersion
    {
        get => new TerraformReference<string>(this, "source_version");
        set => SetArgument("source_version", value);
    }

}


/// <summary>
/// Represents a aws_securitylake_aws_log_source Terraform resource.
/// Manages a aws_securitylake_aws_log_source resource.
/// </summary>
public partial class AwsSecuritylakeAwsLogSource(string name) : TerraformResource("aws_securitylake_aws_log_source", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeAwsLogSourceSourceBlock>? Source
    {
        get => GetArgument<TerraformList<AwsSecuritylakeAwsLogSourceSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}
