using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Provider-specific functions extension for google.
/// </summary>
public static partial class Tf
{
    /// <summary>
    /// GOOGLE provider-specific functions.
    /// </summary>
    public static class Google
    {
        /// <summary>
        /// GOOGLE provider functions.
        /// </summary>
        public static class Functions
        {
            /// <summary>
            /// Returns the location name within a provided resource id, self link, or OP style resource name.
            ///
            /// Takes a single string argument, which should be a resource id, self link, or OP style resource name. This function will either return the location name from the input string or raise an error due to no location being present in the string. The function uses the presence of &amp;quot;locations/{{location}}/&amp;quot; in the input string to identify the location name, e.g. when the function is passed the id &amp;quot;projects/my-project/locations/us-central1/services/my-service&amp;quot; as an argument it will return &amp;quot;us-central1&amp;quot;.
            /// </summary>
            /// <param name="id">A string of a resource&#39;s id, a resource&#39;s self link, or an OP style resource name. For example, &amp;quot;projects/my-project/locations/us-central1/services/my-service&amp;quot; and &amp;quot;https://run.googleapis.com/v2/projects/my-project/locations/us-central1/services/my-service&amp;quot; are valid values containing locations</param>
            public static TerraformExpression LocationFromId(TerraformExpression id)
            {
                return TerraformExpressionExtensions.Call(
                    "provider::google::location_from_id",
                    id
                );
            }

            /// <summary>
            /// Returns the short-form name of a resource within a provided resource&#39;s id, resource URI, self link, or full resource name.
            ///
            /// Takes a single string argument, which should be a resource&#39;s id, resource URI, self link, or full resource name. This function will return the short-form name of a resource from the input string, or raise an error due to a problem with the input string. The function returns the final element in the input string as the resource&#39;s name, e.g. when the function is passed the id &amp;quot;projects/my-project/zones/us-central1-c/instances/my-instance&amp;quot; as an argument it will return &amp;quot;my-instance&amp;quot;.
            /// </summary>
            /// <param name="id">A string of a resource&#39;s id, resource URI, self link, or full resource name. For example, &amp;quot;projects/my-project/zones/us-central1-c/instances/my-instance&amp;quot;, &amp;quot;https://www.googleapis.com/compute/v1/projects/my-project/zones/us-central1-c/instances/my-instance&amp;quot; and &amp;quot;//gkehub.googleapis.com/projects/my-project/locations/us-central1/memberships/my-membership&amp;quot; are valid values</param>
            public static TerraformExpression NameFromId(TerraformExpression id)
            {
                return TerraformExpressionExtensions.Call(
                    "provider::google::name_from_id",
                    id
                );
            }

            /// <summary>
            /// Returns the project within a provided resource&#39;s id, resource URI, self link, or full resource name.
            ///
            /// Takes a single string argument, which should be a resource&#39;s id, resource URI, self link, or full resource name. This function will either return the project name from the input string or raise an error due to no project being present in the string. The function uses the presence of &amp;quot;projects/{{project}}/&amp;quot; in the input string to identify the project name, e.g. when the function is passed the id &amp;quot;projects/my-project/zones/us-central1-c/instances/my-instance&amp;quot; as an argument it will return &amp;quot;my-project&amp;quot;.
            /// </summary>
            /// <param name="id">A string of a resource&#39;s id, resource URI, self link, or full resource name. For example, &amp;quot;projects/my-project/zones/us-central1-c/instances/my-instance&amp;quot;, &amp;quot;https://www.googleapis.com/compute/v1/projects/my-project/zones/us-central1-c/instances/my-instance&amp;quot; and &amp;quot;//gkehub.googleapis.com/projects/my-project/locations/us-central1/memberships/my-membership&amp;quot; are valid values</param>
            public static TerraformExpression ProjectFromId(TerraformExpression id)
            {
                return TerraformExpressionExtensions.Call(
                    "provider::google::project_from_id",
                    id
                );
            }

            /// <summary>
            /// Returns the region name within a provided resource id, self link, or OP style resource name.
            ///
            /// Takes a single string argument, which should be a resource id, self link, or OP style resource name. This function will either return the region name from the input string or raise an error due to no region being present in the string. The function uses the presence of &amp;quot;regions/{{region}}/&amp;quot; in the input string to identify the region name, e.g. when the function is passed the id &amp;quot;projects/my-project/regions/us-central1/subnetworks/my-subnetwork&amp;quot; as an argument it will return &amp;quot;us-central1&amp;quot;.
            /// </summary>
            /// <param name="id">A string of a resource&#39;s id, a resource&#39;s self link, or an OP style resource name. For example, &amp;quot;projects/my-project/regions/us-central1/subnetworks/my-subnetwork&amp;quot; and &amp;quot;https://www.googleapis.com/compute/v1/projects/my-project/regions/us-central1/subnetworks/my-subnetwork&amp;quot; are valid values containing regions</param>
            public static TerraformExpression RegionFromId(TerraformExpression id)
            {
                return TerraformExpressionExtensions.Call(
                    "provider::google::region_from_id",
                    id
                );
            }

            /// <summary>
            /// Returns the region within a provided resource&#39;s zone
            ///
            /// Takes a single string argument, which should be a resource&#39;s zone.
            /// </summary>
            /// <param name="zone">A string of a resource&#39;s zone.</param>
            public static TerraformExpression RegionFromZone(TerraformExpression zone)
            {
                return TerraformExpressionExtensions.Call(
                    "provider::google::region_from_zone",
                    zone
                );
            }

            /// <summary>
            /// Returns the zone name within the resource id or self link provided as an argument.
            ///
            /// Takes a single string argument, which should be an id or self link of a resource. This function will either return the zone name from the input string or raise an error due to no zone being present in the string. The function uses the presence of &amp;quot;zones/{{zone}}/&amp;quot; in the input string to identify the zone name, e.g. when the function is passed the id &amp;quot;projects/my-project/zones/us-central1-c/instances/my-instance&amp;quot; as an argument it will return &amp;quot;us-central1-c&amp;quot;.
            /// </summary>
            /// <param name="id">An id of a resource, or a self link. For example, both &amp;quot;projects/my-project/zones/us-central1-c/instances/my-instance&amp;quot; and &amp;quot;https://www.googleapis.com/compute/v1/projects/my-project/zones/us-central1-c/instances/my-instance&amp;quot; are valid inputs</param>
            public static TerraformExpression ZoneFromId(TerraformExpression id)
            {
                return TerraformExpressionExtensions.Call(
                    "provider::google::zone_from_id",
                    id
                );
            }

        }
    }
}
