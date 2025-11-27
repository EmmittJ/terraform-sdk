using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsOpensearchInboundConnectionAccepter.
/// Nesting mode: single
/// </summary>
public class AwsOpensearchInboundConnectionAccepterTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_opensearch_inbound_connection_accepter Terraform resource.
/// Manages a aws_opensearch_inbound_connection_accepter resource.
/// </summary>
public partial class AwsOpensearchInboundConnectionAccepter(string name) : TerraformResource("aws_opensearch_inbound_connection_accepter", name)
{
    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformValue<string> ConnectionId
    {
        get => new TerraformReference<string>(this, "connection_id");
        set => SetArgument("connection_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    public TerraformValue<string> ConnectionStatus
    {
        get => new TerraformReference<string>(this, "connection_status");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsOpensearchInboundConnectionAccepterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsOpensearchInboundConnectionAccepterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
