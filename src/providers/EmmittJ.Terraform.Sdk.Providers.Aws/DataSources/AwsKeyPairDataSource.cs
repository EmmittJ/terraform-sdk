using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsKeyPairDataSource.
/// Nesting mode: set
/// </summary>
public class AwsKeyPairDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsKeyPairDataSource.
/// Nesting mode: single
/// </summary>
public class AwsKeyPairDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_key_pair Terraform data source.
/// Retrieves information about a aws_key_pair.
/// </summary>
public partial class AwsKeyPairDataSource(string name) : TerraformDataSource("aws_key_pair", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The include_public_key attribute.
    /// </summary>
    public TerraformValue<bool>? IncludePublicKey
    {
        get => new TerraformReference<bool>(this, "include_public_key");
        set => SetArgument("include_public_key", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string>? KeyName
    {
        get => new TerraformReference<string>(this, "key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// The key_pair_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyPairId
    {
        get => new TerraformReference<string>(this, "key_pair_id");
        set => SetArgument("key_pair_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The fingerprint attribute.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformValue<string> KeyType
    {
        get => new TerraformReference<string>(this, "key_type");
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformValue<string> PublicKey
    {
        get => new TerraformReference<string>(this, "public_key");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKeyPairDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsKeyPairDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsKeyPairDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsKeyPairDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
