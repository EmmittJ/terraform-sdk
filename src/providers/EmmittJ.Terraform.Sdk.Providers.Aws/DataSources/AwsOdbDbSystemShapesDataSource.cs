using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_db_system_shapes Terraform data source.
/// Retrieves information about a aws_odb_db_system_shapes.
/// </summary>
public partial class AwsOdbDbSystemShapesDataSource(string name) : TerraformDataSource("aws_odb_db_system_shapes", name)
{
    /// <summary>
    /// The physical ID of the AZ, for example, use1-az4. This ID persists across accounts.
    /// </summary>
    public TerraformValue<string>? AvailabilityZoneId
    {
        get => GetArgument<TerraformValue<string>>("availability_zone_id");
        set => SetArgument("availability_zone_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The list of shapes and their properties. Information about a hardware system model (shape) that&#39;s available for an Exadata infrastructure.The shape determines resources, such as CPU cores, memory, and storage, to allocate to the Exadata infrastructure.
    /// </summary>
    public TerraformList<TerraformMap<object>> DbSystemShapes
        => AsReference("db_system_shapes");

}
