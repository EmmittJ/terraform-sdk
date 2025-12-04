using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dx_location Terraform data source.
/// Retrieves information about a aws_dx_location.
/// </summary>
public partial class AwsDxLocationDataSource(string name) : TerraformDataSource("aws_dx_location", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationCode is required")]
    public required TerraformValue<string> LocationCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("location_code");
        set => SetArgument("location_code", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The available_macsec_port_speeds attribute.
    /// </summary>
    public TerraformList<string> AvailableMacsecPortSpeeds
        => AsReference("available_macsec_port_speeds");

    /// <summary>
    /// The available_port_speeds attribute.
    /// </summary>
    public TerraformList<string> AvailablePortSpeeds
        => AsReference("available_port_speeds");

    /// <summary>
    /// The available_providers attribute.
    /// </summary>
    public TerraformList<string> AvailableProviders
        => AsReference("available_providers");

    /// <summary>
    /// The location_name attribute.
    /// </summary>
    public TerraformValue<string> LocationName
        => AsReference("location_name");

}
