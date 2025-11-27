using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsMacie2CustomDataIdentifier.
/// Nesting mode: single
/// </summary>
public class AwsMacie2CustomDataIdentifierTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_macie2_custom_data_identifier Terraform resource.
/// Manages a aws_macie2_custom_data_identifier resource.
/// </summary>
public partial class AwsMacie2CustomDataIdentifier(string name) : TerraformResource("aws_macie2_custom_data_identifier", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ignore_words attribute.
    /// </summary>
    public TerraformSet<string>? IgnoreWords
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ignore_words").ResolveNodes(ctx));
        set => SetArgument("ignore_words", value);
    }

    /// <summary>
    /// The keywords attribute.
    /// </summary>
    public TerraformSet<string>? Keywords
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "keywords").ResolveNodes(ctx));
        set => SetArgument("keywords", value);
    }

    /// <summary>
    /// The maximum_match_distance attribute.
    /// </summary>
    public TerraformValue<double> MaximumMatchDistance
    {
        get => new TerraformReference<double>(this, "maximum_match_distance");
        set => SetArgument("maximum_match_distance", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformValue<string>? Regex
    {
        get => new TerraformReference<string>(this, "regex");
        set => SetArgument("regex", value);
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
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMacie2CustomDataIdentifierTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMacie2CustomDataIdentifierTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
