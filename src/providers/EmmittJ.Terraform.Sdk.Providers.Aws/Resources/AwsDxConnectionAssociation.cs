using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dx_connection_association Terraform resource.
/// Manages a aws_dx_connection_association resource.
/// </summary>
public partial class AwsDxConnectionAssociation(string name) : TerraformResource("aws_dx_connection_association", name)
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
    /// The lag_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LagId is required")]
    public required TerraformValue<string> LagId
    {
        get => new TerraformReference<string>(this, "lag_id");
        set => SetArgument("lag_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}
