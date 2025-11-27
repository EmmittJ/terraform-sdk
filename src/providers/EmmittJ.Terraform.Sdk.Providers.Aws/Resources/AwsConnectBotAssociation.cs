using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for lex_bot in AwsConnectBotAssociation.
/// Nesting mode: list
/// </summary>
public class AwsConnectBotAssociationLexBotBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lex_bot";

    /// <summary>
    /// The lex_region attribute.
    /// </summary>
    public TerraformValue<string> LexRegion
    {
        get => new TerraformReference<string>(this, "lex_region");
        set => SetArgument("lex_region", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Represents a aws_connect_bot_association Terraform resource.
/// Manages a aws_connect_bot_association resource.
/// </summary>
public partial class AwsConnectBotAssociation(string name) : TerraformResource("aws_connect_bot_association", name)
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
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
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
    /// LexBot block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LexBot is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LexBot block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LexBot block(s) allowed")]
    public required TerraformList<AwsConnectBotAssociationLexBotBlock> LexBot
    {
        get => GetRequiredArgument<TerraformList<AwsConnectBotAssociationLexBotBlock>>("lex_bot");
        set => SetArgument("lex_bot", value);
    }

}
